namespace NoMansSky.Api;

public interface INMSHook
{
    /// <summary>
    /// Used to specify whether the hook should run before or after the game's original function.
    /// </summary>
    RunHook HookTime { get; }

    /// <summary>
    /// The ModEventHook that is attached to the actual game function.
    /// </summary>
    IModEventHook<object[]?> EventHook { get; }

    /// <summary>
    /// Reflects whether or not this hook has been successfully loaded.
    /// </summary>
    bool IsSuccessfullyLoaded { get; }
}
