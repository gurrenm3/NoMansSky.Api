namespace NoMansSky.Api.Hooks;

internal unsafe class GcPlayerState_Hooks
{
    [NMSHook<cGcPlayerState.ConstructFunc>]
    public static void ConstructHook(long self)
    {
        if (IGame.Instance.Player.GcPlayerStatePtr != self)
        {
            IGame.Instance.Player.GcPlayerStatePtr = self;
            IGame.Instance.Player.OnGcPlayerStateAquired.Run();

            ConsoleUtils.WriteLine($"Acquired GcPlayerState: {self.ToHex()}");
        }
    }
}
