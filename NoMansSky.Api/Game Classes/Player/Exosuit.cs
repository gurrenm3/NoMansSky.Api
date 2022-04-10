using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public unsafe class Exosuit : IExosuit
    {
        private GcPlayerStateData* state;

        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        public Exosuit()
        {
            var game = Game.Instance;
            var player = game.Player;
            var onAquired = player.OnPlayerStateAquired;

            Game.Instance.Player.OnPlayerStateAquired += (address) =>
            {
                state = (GcPlayerStateData*)address;
            };
        }

        /// <summary>
        /// Initializes this object. Called after the player has selected a profile.
        /// </summary>
        /// <param name="playerStateAddress"></param>
        private void Initialize(long playerStateAddress)
        {
            
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public Inventory GetInventory()
        {
            var inventory = new Inventory();
            inventory.InitFromAddress(state->exosuitInventoryAddress);
            return inventory;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public Inventory GetTechnology()
        {
            var inventory = new Inventory();
            inventory.InitFromAddress(state->exosuitTechnologyAddress);
            return inventory;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public Inventory GetCargo()
        {
            var inventory = new Inventory();
            inventory.InitFromAddress(state->exosuitCargoAddress);
            return inventory;
        }
    }
}
