using System;
using NativeApiHooking.Common;
using NativeApiHooking.Common.Modules.User32;

namespace NativeApiHooking.Trampolining
{
    public static class Program
    {
        static IHook hook;

        public static void Main(string[] args)
        {
            hook = new DefaultHookFactory().Trampoline(new MessageBoxTrampoline());
            hook.Attach();

            System.Windows.Forms.MessageBox.Show(
                "Hello, World!", 
                "Test", 
                System.Windows.Forms.MessageBoxButtons.OK, 
                System.Windows.Forms.MessageBoxIcon.Information);
        }
    }

    public class MessageBoxTrampoline : MessageBoxWTrampoline
    {
        private const long MB_OK = 0x00000000L;
        private const long MB_ICONWARNING = 0x00000030L;
        private const long MB_SYSTEMMODAL = 0x00001000L;
        private const long MB_RTLREADING = 0x00100000L;
        private const uint TYPE = (uint)(MB_OK | MB_ICONWARNING | MB_SYSTEMMODAL | MB_RTLREADING);

        public override int MessageBoxW(IntPtr hWnd, string text, string caption, uint type)
        {
            Original(hWnd, "Behaviour of original message box is altered", "Hooked", TYPE);

            return Original(hWnd, "No hello today", caption, type);
        }
    }
}
