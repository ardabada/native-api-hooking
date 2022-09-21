using System;

namespace NativeApiHooking.Common
{
    public abstract class TrampolineHookBase<T> : IHookBehaviour where T : Delegate
    {
        public T Original { get; internal set; }

        public abstract Delegate GetAlteredBehaviour();
    }

    public abstract class TrampolineModuledHookBase<T> : TrampolineHookBase<T>, IModuledHook where T : Delegate
    {
        public abstract string ModuleName { get; }

        public abstract string ProcName { get; }
    }
}
