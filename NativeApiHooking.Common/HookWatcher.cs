using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace NativeApiHooking.Common
{
    internal static class HookWatcher
    {
        private static readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
        private static HashSet<string> hookedModules = new HashSet<string>();

        public static bool IsAttached(string moduleName, string procName)
        {
            string name = GetWatcherName(moduleName, procName);
            _lock.EnterReadLock();
            try
            {
                return hookedModules.Contains(name);
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }

        public static void Attach(string moduleName, string procName)
        {
            string name = GetWatcherName(moduleName, procName);
            _lock.EnterWriteLock();
            try
            {
                hookedModules.Add(name);
                Debug.WriteLine($"Attached {name}");
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        public static void Detach(string moduleName, string procName)
        {
            string name = GetWatcherName(moduleName, procName);
            _lock.EnterWriteLock();
            try
            {
                hookedModules.Remove(name);
                Debug.WriteLine($"Detached {name}");
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        private static string GetWatcherName(string moduleName, string procName) => moduleName + "->" + procName;
    }
}
