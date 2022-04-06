namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the player's exosuit.
    /// </summary>
    public unsafe class Exosuit
    {
        private GcPlayerStateData* state;

        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        public Exosuit()
        {
            // Initialize when we have the player pointer
            Game.Instance.Player.OnPlayerStateAquired += Initialize; 
        }

        /// <summary>
        /// Initializes this object. Called after the player has selected a profile.
        /// </summary>
        /// <param name="playerStateAddress"></param>
        internal void Initialize(long playerStateAddress)
        {
            state = (GcPlayerStateData*)playerStateAddress;
        }

        /// <summary>
        /// Returns the Exosuit's general inventory.
        /// </summary>
        /// <returns></returns>
        public Inventory GetInventory()
        {
            var inventory = new Inventory();
            inventory.InitFromAddress(state->exosuitInventoryAddress);
            return inventory;
        }

        /// <summary>
        /// Returns the Exosuit's technology inventory.
        /// </summary>
        /// <returns></returns>
        public Inventory GetTechnology()
        {
            var inventory = new Inventory();
            inventory.InitFromAddress(state->exosuitTechnologyAddress);
            return inventory;
        }

        /// <summary>
        /// Returns the Exosuit's cargo inventory.
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
