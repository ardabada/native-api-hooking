namespace NativeApiHooking.Common
{
    public enum HookAttachStatus
    {
        Attached = 0,
        AlreadyAttached = 1,
        ModuleNotLoaded = 2,
        ProcNotFound = 3,
        AttachFailed = 4
    }

    public enum HookDetachStatus
    {
        Detached = 0,
        NotAttached = 1,
        DetachFailed = 2
    }
}
