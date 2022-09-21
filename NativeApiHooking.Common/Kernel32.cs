using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NativeApiHooking.Common
{
    internal static class Kernel32
    {
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Module.Kernel32, EntryPoint = "CopyMemory", SetLastError = false)]
        public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);

        [DllImport(Module.Kernel32, EntryPoint = "GetProcAddress", SetLastError = true)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Module.Kernel32, EntryPoint = "GetModuleHandle", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Module.Kernel32, EntryPoint = "VirtualProtect", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Module.Kernel32, EntryPoint = "LoadLibrary", SetLastError = true, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.SysInt)]
        public static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    }
}
