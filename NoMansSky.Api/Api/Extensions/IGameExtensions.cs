using NoMansSky.Api.Hooks;

namespace NoMansSky.Api;

public static unsafe class IGameExtensions
{
    /// <summary>
    /// Returns the instance of GcApplication.
    /// </summary>
    /// <param name="game"></param>
    /// <returns></returns>
    public static cGcApplication* GetApplication(this IGame game)
    {
        return (cGcApplication*)game.GcApplicationPtr;
    }

    /// <summary>
    /// Returns the instance of GcSimulation.
    /// </summary>
    /// <param name="game"></param>
    /// <returns></returns>
    public static cGcSimulation* GetSimulation(this IGame game)
    {
        return (cGcSimulation*)game.GetApplication()->GetSimulation();
    }


    /// <summary>
    /// Returns the instance of GcGameState.
    /// </summary>
    /// <param name="game"></param>
    /// <returns></returns>
    public static cGcGameState* GetGameState(this IGame game)
    {
        return (cGcGameState*)game.GetApplication()->GetGameState();
    }
}
