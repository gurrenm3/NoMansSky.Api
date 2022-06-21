namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the "Warning, Mods are Enabled" popup that shows at the beginning of the game.
    /// <br/><br/>Thanks to RaYRoD TV#7679 for discovering and sharing this.
    /// </summary>
    public interface IModWarning
    {
        /// <summary>
        /// Reflects whether or not the mod warning is currently enabled.
        /// </summary>
        public bool IsEnabled { get; }

        /// <summary>
        /// Force the mod warning to show.
        /// </summary>
        public void Enable();

        /// <summary>
        /// Prevent the mod warning from showing.
        /// </summary>
        public void Disable();
    }
}
