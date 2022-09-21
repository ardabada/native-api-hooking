using System;

namespace NativeApiHooking.Common
{
    public class DefaultHookFactory : IHookFactory
    {
        private static bool Is32Bit = IntPtr.Size == 4;

        public IHook Splicing<T>(string moduleName, string procName, T hook)
            where T : Delegate
        {
            if (!Is32Bit) throw new InvalidOperationException("Only x86 is supported.");

            return new Native32SplicingHook(moduleName, procName, hook);
        }
        public IHook Splicing<T>(T behaviour)
           where T : IModuledHook, IHookBehaviour
        {
            return Splicing(behaviour.ModuleName, behaviour.ProcName, behaviour.GetAlteredBehaviour());
        }

        public IHook Trampoline<T>(string moduleName, string procName, TrampolineHookBase<T> behaviour)
            where T : Delegate
        {
            if (!Is32Bit) throw new InvalidOperationException("Only x86 is supported.");

            return new Native32TrampolineHook<T>(moduleName, procName, behaviour);
        }

        public IHook Trampoline<T>(TrampolineModuledHookBase<T> behaviour)
           where T : Delegate
        {
            return Trampoline(behaviour.ModuleName, behaviour.ProcName, behaviour);
        }
    }
}
