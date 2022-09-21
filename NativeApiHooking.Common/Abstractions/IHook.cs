namespace NativeApiHooking.Common
{
    public interface IHook
    {
        HookAttachStatus Attach();

        HookDetachStatus Detach();
    }
}
