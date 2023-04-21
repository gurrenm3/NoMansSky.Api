using NoMansSky.Api.Hooks;

namespace NoMansSky.Api;

public static unsafe class IGameExtensions
{
    public static cGcApplication* GetGcApplication(this IGame game)
    {
        //return GcApplication_Hooks.gcApplicationInstance;
        return (cGcApplication*)game.GcApplicationPtr;
    }
}
