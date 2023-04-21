using NoMansSky.Api.Definitions;

namespace NoMansSky.Api.Hooks;

internal unsafe class GcApplication_Hooks
{
    [NMSHook<cGcApplication.GetFrontendManagerFunc>]
    public static void GetFrontendManagerFunc(long self)
    {
        if (IGame.Instance.GcApplicationPtr != self)
        {
            IGame.Instance.GcApplicationPtr = self;
            ConsoleUtils.WriteLine($"Acquired GcApplication: {self.ToHex()}");
        }
    }

    [NMSHook<cGcApplication.UpdateFunc>(RunHook.Before)]
    public static void UpdateBefore()
    {
        IGame.Instance.GameLoop.OnUpdate.Before.Run();
    }


    [NMSHook<cGcApplication.UpdateFunc>(RunHook.After)]
    public static void UpdateAfter()
    {
        IGame.Instance.GameLoop.OnUpdate.After.Run();
    }
}
