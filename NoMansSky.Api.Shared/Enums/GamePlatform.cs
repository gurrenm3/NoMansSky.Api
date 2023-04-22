namespace NoMansSky.Api;

/// <summary>
/// Used to specify which platform something should run on.
/// </summary>
public enum GamePlatform
{
    /// <summary>
    /// Default value for this enum.
    /// </summary>
    None,

    /// <summary>
    /// Runs on all versions of the game.
    /// </summary>
    All,

    /// <summary>
    /// Runs on Steam version of the game.
    /// </summary>
    Steam,

    /// <summary>
    /// Runs on GOG version of the game.
    /// </summary>
    GOG
}
