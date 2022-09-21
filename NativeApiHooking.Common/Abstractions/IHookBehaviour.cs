using System;

namespace NativeApiHooking.Common
{
    public interface IHookBehaviour
    {
        Delegate GetAlteredBehaviour();
    }
}
