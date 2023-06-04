using NoMansSky.Api.Hooks;

namespace NoMansSky.Api;

/// <summary>
/// Extension methods for <see cref="IPlayer"/>.
/// </summary>
public static unsafe class IPlayerExtensions
{
    public static cGcPlayer* GetPlayer(this IPlayer player)
    {
        return &IGame.Instance.GetSimulation()->player;
        //return (cGcPlayer*)player.GcPlayerPtr;
    }

    public static cGcPlayerState* GetPlayerState(this IPlayer player)
    {
        return &IGame.Instance.GetGameState()->playerState;
        //return (cGcPlayerState*)player.GcPlayerStatePtr;
    }
}
