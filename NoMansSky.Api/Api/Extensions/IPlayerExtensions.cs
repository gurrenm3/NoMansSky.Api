using NoMansSky.Api.Hooks;

namespace NoMansSky.Api;

/// <summary>
/// Extension methods for <see cref="IPlayer"/>.
/// </summary>
public static unsafe class IPlayerExtensions
{
    public static cGcPlayer* GetGcPlayer(this IPlayer player)
    {
        return (cGcPlayer*)player.GcPlayerPtr;
    }

    public static cGcPlayerState* GetGcPlayerState(this IPlayer player)
    {
        return (cGcPlayerState*)player.GcPlayerStatePtr;
    }
}
