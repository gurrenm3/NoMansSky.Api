using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the player's exosuit.
    /// </summary>
    internal unsafe class Exosuit : IExosuit
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IRefiner SuitRefiner =>_suitRefiner;
        private IRefiner _suitRefiner;


        private GcPlayerStateData* state;
        private IModLogger logger;

        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        public Exosuit(IModLogger logger)
        {
            this.logger = logger;
            var game = Game.Instance;
            var player = game.Player;
            var onAquired = player.OnPlayerStateAquired;

            player.OnPlayerStateAquired += (address) =>
            {
                state = (GcPlayerStateData*)address;
            };

            game.MBinManager.OnMBinLoaded += (mbin) =>
            {
                if (mbin.Name != "cGcRefinerUnitComponentData")
                    return;
                
                if (mbin.Address == 0)
                {
                    logger.WriteLine("Failed to get address for suit refiner.", LogLevel.Error);
                    return;
                }

                var address = mbin.Address + 0x100;
                logger.WriteLine($"Suit Refiner address: {address.ToString("X")}", LogLevel.CheatEngine);
                _suitRefiner = new Refiner(address);
            };
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public IInventory GetInventory()
        {
            var inventory = new Inventory();
            inventory.InitFromAddress(state->exosuitInventoryAddress);
            return inventory;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public IInventory GetTechnology()
        {
            var inventory = new Inventory();
            inventory.InitFromAddress(state->exosuitTechnologyAddress);
            return inventory;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public IInventory GetCargo()
        {
            var inventory = new Inventory();
            inventory.InitFromAddress(state->exosuitCargoAddress);
            return inventory;
        }
    }
}
