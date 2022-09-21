using System;
using NativeApiHooking.Common;
using NativeApiHooking.Common.Modules.User32;

namespace NativeApiHooking.Splicing
{
    internal static class HookDemo
    {
        private static IHook hook;

        private const int ID_YES = 6;

        private static int AlwaysYesMessageBoxW(IntPtr hWnd, string text, string caption, uint type)
        {
            return ID_YES;
        }

        public static void Install()
        {
            hook = new DefaultHookFactory()
                .Splicing<MessageBoxW>(Module.User32, "MessageBoxW", AlwaysYesMessageBoxW);
            hook.Attach();
        }
    }
}
