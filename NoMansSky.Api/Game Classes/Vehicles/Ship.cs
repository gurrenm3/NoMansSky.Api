using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public class Ship : IShip
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEventHook<int> OnHealthChanged { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEventHook<int> OnShieldChanged { get; set; }

        /// <summary>
        /// Creates a new instance of this class.
        /// </summary>
        public Ship()
        {
            OnHealthChanged = new SharedModEventHook<int>();
            OnShieldChanged = new SharedModEventHook<int>();
        }
    }
}
