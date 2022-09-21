using System;
using System.Runtime.InteropServices;
using static NativeApiHooking.Common.Kernel32;

namespace NativeApiHooking.Common
{
    internal class Native32SplicingHook : IHook
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

        private readonly IntPtr originalBytes = Marshal.AllocHGlobal(SPLICING_JUMP_SIZE);

        private readonly string moduleName;
        private readonly string procName;
        private readonly IntPtr hookAddress;
        private IntPtr originalAddress;
        private readonly Delegate hook; //preserve the reference to delegate to avoid delegate being gc

        internal Native32SplicingHook(string moduleName, string procName, Delegate hook)
        {
            this.moduleName = moduleName;
            this.procName = procName;
            this.hook = hook;
            this.hookAddress = Marshal.GetFunctionPointerForDelegate(hook);
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

                Redirect(originalAddress, hookAddress);

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

                VirtualProtect(originalAddress, (UIntPtr)SPLICING_JUMP_SIZE, PAGE_EXECUTE_READWRITE, out uint oldProtect);

                CopyMemory(originalAddress, originalBytes, SPLICING_JUMP_SIZE);

                VirtualProtect(originalAddress, (UIntPtr)SPLICING_JUMP_SIZE, oldProtect, out _);

                HookWatcher.Detach(moduleName, procName);
                Marshal.FreeHGlobal(originalBytes);

                return HookDetachStatus.Detached;
            }
            catch { return HookDetachStatus.DetachFailed; }
        }

        private void Redirect(IntPtr original, IntPtr target)
        {
            byte[] jump = new byte[SPLICING_JUMP_TEMPLATE.Length];
            Array.Copy(SPLICING_JUMP_TEMPLATE, jump, SPLICING_JUMP_TEMPLATE.Length);
            int jmpSize = target.ToInt32() - original.ToInt32() - JUMP_INSTRUCTION_SIZE;
            VirtualProtect(original, (UIntPtr)SPLICING_JUMP_SIZE, PAGE_EXECUTE_READWRITE, out uint oldProtect);
            CopyMemory(originalBytes, original, SPLICING_JUMP_SIZE);

            var bytes = BitConverter.GetBytes(jmpSize);
            Array.Copy(bytes, 0, jump, JUMP_OPCODE_SIZE, JUMP_ADDRESS_SIZE);
            Marshal.Copy(jump, 0, original, jump.Length);
            VirtualProtect(original, (UIntPtr)SPLICING_JUMP_SIZE, oldProtect, out _);
        }
    }
}
