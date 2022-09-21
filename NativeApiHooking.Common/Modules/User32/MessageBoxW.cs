using System;
using System.Runtime.InteropServices;

namespace NativeApiHooking.Common.Modules.User32
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall, SetLastError = true, CharSet = CharSet.Auto, BestFitMapping = false)]
    public delegate int MessageBoxW(IntPtr hWnd, string text, string caption, uint type);

    public abstract class MessageBoxWTrampoline : TrampolineModuledHookBase<MessageBoxW>
    {
        public sealed override string ModuleName => Module.User32;

        public sealed override string ProcName => "MessageBoxW";

        public sealed override Delegate GetAlteredBehaviour()
        {
            return new MessageBoxW(MessageBoxW);
        }

        public abstract int MessageBoxW(IntPtr hWnd, string text, string caption, uint type);
    }
}
