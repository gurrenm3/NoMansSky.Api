using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the player's ship.
    /// </summary>
    internal class Ship : IShip
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Stat<int> Health { get; set; }

        /// <summary>
        /// NOT IMPLEMENTED
        /// <br/><br/>
        /// <inheritdoc/>
        /// </summary>
        public Stat<int> Shield 
        { 
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException(); 
        }

        /// <summary>
        /// Creates a new instance of this class.
        /// </summary>
        public Ship()
        {
            Health = new RealStat<int>();
            Health.OnValueChanged = new SharedModEventHook<int>();

            /*Shield = new RealStat<int>();
            Shield.OnValueChanged = new SharedModEventHook<int>();*/

            Game.Instance.Player.OnPlayerStateAquired += OnGcPlayerStateAcquired;
        }

        private void OnGcPlayerStateAcquired(long address)
        {
            (Health as RealStat<int>)?.Init("Health", address + 0xB8);
        }
    }
}
