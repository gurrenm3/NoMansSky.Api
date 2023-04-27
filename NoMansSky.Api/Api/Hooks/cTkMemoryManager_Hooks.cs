namespace NoMansSky.Api;

internal unsafe class cTkMemoryManager_Hooks
{
    [NMSHook<cTkMemoryManager.ConstructFunc>]
    public static void Construct(long self)
    {
        IGame.Instance.TkMemoryManager.OnPointerAcquired.Run(self);
    }
}
