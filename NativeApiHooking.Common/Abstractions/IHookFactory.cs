using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeApiHooking.Common
{
    public interface IHookFactory
    {
        IHook Splicing<T>(string moduleName, string procName, T hook)
            where T : Delegate;

        IHook Splicing<T>(T behaviour)
            where T : IModuledHook, IHookBehaviour;

        IHook Trampoline<T>(string moduleName, string procName, TrampolineHookBase<T> behaviour)
           where T : Delegate;

        IHook Trampoline<T>(TrampolineModuledHookBase<T> behaviour)
           where T : Delegate;
    }
}
