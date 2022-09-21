using System;
using System.Runtime.InteropServices;
using NativeApiHooking.Common.Disasm;
using static NativeApiHooking.Common.Kernel32;

namespace NativeApiHooking.Common
{
    internal class Native32TrampolineHook<T> : IHook where T : Delegate
    {
        private const byte JMP = 0xE9;
        private const byte NOP = 0x90;
        private const byte RET = 0xC3;
        private const uint PAGE_EXECUTE_READWRITE = 0x40;

        private const int RETURN_OPCODE_SIZE = 1;
        private const int JUMP_OPCODE_SIZE = 1;
        private const int JUMP_ADDRESS_SIZE = 4;
        private const int JUMP_INSTRUCTION_SIZE = JUMP_OPCODE_SIZE + JUMP_ADDRESS_SIZE;
        private const int SPLICING_JUMP_SIZE = JUMP_INSTRUCTION_SIZE + RETURN_OPCODE_SIZE;
        private readonly byte[] SPLICING_JUMP_TEMPLATE = new byte[SPLICING_JUMP_SIZE] { JMP, NOP, NOP, NOP, NOP, RET };

        private const int TRAMPOLINE_SAFE_SIZE = SPLICING_JUMP_SIZE * 4;
        private readonly byte[] OLD_BYTES = new byte[TRAMPOLINE_SAFE_SIZE];

        private readonly string moduleName;
        private readonly string procName;
        private readonly TrampolineHookBase<T> hook;
        private IntPtr originalAddress;

        private GCHandle trampolineHandle;

        internal Native32TrampolineHook(string moduleName, string procName, TrampolineHookBase<T> hook)
        {
            this.moduleName = moduleName;
            this.procName = procName;
            this.hook = hook;
        }

        public HookAttachStatus Attach()
        {
            try
            {
                if (HookWatcher.IsAttached(moduleName, procName)) return HookAttachStatus.AlreadyAttached;

                var module = GetModuleHandle(moduleName);
                if (module == IntPtr.Zero) return HookAttachStatus.ModuleNotLoaded;

                originalAddress = GetProcAddress(module, procName);
                if (originalAddress == IntPtr.Zero) return HookAttachStatus.ProcNotFound;

                var hookAddress = Marshal.GetFunctionPointerForDelegate(hook.GetAlteredBehaviour());
                Redirect(originalAddress, hookAddress);
                CreateTrampoline(originalAddress, OLD_BYTES);

                HookWatcher.Attach(moduleName, procName);

                return HookAttachStatus.Attached;
            }
            catch { return HookAttachStatus.AttachFailed; }
        }

        public HookDetachStatus Detach()
        {
            try
            {
                if (!HookWatcher.IsAttached(moduleName, procName) || originalAddress == IntPtr.Zero) return HookDetachStatus.NotAttached;

                VirtualProtect(originalAddress, (UIntPtr)TRAMPOLINE_SAFE_SIZE, PAGE_EXECUTE_READWRITE, out uint oldProtect);

                Marshal.Copy(OLD_BYTES, 0, originalAddress, TRAMPOLINE_SAFE_SIZE);

                VirtualProtect(originalAddress, (UIntPtr)TRAMPOLINE_SAFE_SIZE, oldProtect, out _);

                HookWatcher.Detach(moduleName, procName);
                trampolineHandle.Free();

                return HookDetachStatus.Detached;
            }
            catch { return HookDetachStatus.DetachFailed; }
        }

        private void Redirect(IntPtr original, IntPtr target)
        {
            byte[] jump = new byte[SPLICING_JUMP_TEMPLATE.Length];
            Array.Copy(SPLICING_JUMP_TEMPLATE, jump, SPLICING_JUMP_TEMPLATE.Length);
            int jmpSize = target.ToInt32() - original.ToInt32() - JUMP_INSTRUCTION_SIZE;
            VirtualProtect(original, (UIntPtr)TRAMPOLINE_SAFE_SIZE, PAGE_EXECUTE_READWRITE, out uint oldProtect);
            Marshal.Copy(original, OLD_BYTES, 0, OLD_BYTES.Length);

            var bytes = BitConverter.GetBytes(jmpSize);
            Array.Copy(bytes, 0, jump, JUMP_OPCODE_SIZE, JUMP_ADDRESS_SIZE);
            Marshal.Copy(jump, 0, original, jump.Length);
            VirtualProtect(original, (UIntPtr)TRAMPOLINE_SAFE_SIZE, oldProtect, out _);
        }

        private void CreateTrampoline(IntPtr original, byte[] oldBytes)
        {
            var index = FindTrampolineCopyIndex(oldBytes);
            byte[] trampoline = new byte[index + SPLICING_JUMP_SIZE];
            Array.Copy(oldBytes, 0, trampoline, 0, index);
            Array.Copy(SPLICING_JUMP_TEMPLATE, 0, trampoline, index, SPLICING_JUMP_TEMPLATE.Length);

            trampolineHandle = GCHandle.Alloc(trampoline, GCHandleType.Pinned);
            var addr = trampolineHandle.AddrOfPinnedObject();
            VirtualProtect(addr, (UIntPtr)trampoline.Length, PAGE_EXECUTE_READWRITE, out _);

            int jmpSize = original.ToInt32() - addr.ToInt32() - JUMP_INSTRUCTION_SIZE;

            var bytes = BitConverter.GetBytes(jmpSize);
            Array.Copy(bytes, 0, trampoline, index + JUMP_OPCODE_SIZE, JUMP_ADDRESS_SIZE);
            Marshal.Copy(trampoline, 0, addr, index);
            hook.Original = (T)Marshal.GetDelegateForFunctionPointer(addr, typeof(T));

            FillHookedWithNops(original, index);
        }

        private void FillHookedWithNops(IntPtr original, int trampolineIndex)
        {
            IntPtr oldBytes = Marshal.AllocHGlobal(TRAMPOLINE_SAFE_SIZE);
            byte[] updatedOriginalBytes = new byte[TRAMPOLINE_SAFE_SIZE];
            VirtualProtect(original, (UIntPtr)TRAMPOLINE_SAFE_SIZE, PAGE_EXECUTE_READWRITE, out uint oldProtect);
            CopyMemory(oldBytes, original, TRAMPOLINE_SAFE_SIZE);
            Marshal.Copy(oldBytes, updatedOriginalBytes, 0, updatedOriginalBytes.Length);

            for (int i = SPLICING_JUMP_SIZE; i < trampolineIndex; i++)
                updatedOriginalBytes[i] = NOP;

            Marshal.Copy(updatedOriginalBytes, 0, original, updatedOriginalBytes.Length);
            VirtualProtect(original, (UIntPtr)TRAMPOLINE_SAFE_SIZE, oldProtect, out _);
        }

        private int FindTrampolineCopyIndex(byte[] original)
        {
            int current = 0;
            while (current < original.Length)
            {
                try
                {
                    var inst = DisASMx86.ParseInstruction(original, current);
                    current += inst.Length;

                    if (current > SPLICING_JUMP_SIZE) return current;
                }
                catch
                {
                    break;
                }
            }
            return -1;
        }
    }
}
