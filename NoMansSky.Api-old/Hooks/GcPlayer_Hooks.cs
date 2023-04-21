namespace NoMansSky.Api.Hooks;

internal unsafe class cGcPlayer_Hooks
{
    [NMSHook<cGcPlayer.ConstructFunc>]
    public static void ConstructHook(long self)
    {
        if (IGame.Instance.Player.GcPlayerPtr != self)
        {
            IGame.Instance.Player.GcPlayerPtr = self;
            IGame.Instance.Player.OnGcPlayerAquired.Run();

            ConsoleUtils.WriteLine($"Acquired GcPlayer: {self.ToHex()}");
        }
    }
}
