namespace NativeApiHooking.Common
{
    public interface IModuledHook
    {
        string ModuleName { get; }

        string ProcName { get; }
    }
}
