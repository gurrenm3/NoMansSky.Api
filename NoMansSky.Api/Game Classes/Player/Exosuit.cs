using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public unsafe class Exosuit : IExosuit
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IRefiner SuitRefiner { get; set; }

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
                if (mbin.Name == GcComponent.cGcRefinerUnitComponentData.ToString())
                {
                    var baseAddress = mbin.Address + 0x100;
                    //var address = (long)(long*)((byte*)baseAddress);
                    var address = baseAddress;
                    //System.Console.WriteLine($"AAA: {address}");
                    SuitRefiner = new Refiner(address);

                    if (address != 100)
                    {
                        logger.WriteLine($"[For CheatEngine Users] Suit Refiner address: {address.ToString("X")}");
                    }
                }
            };
        }

        private void Test(long baseAddress)
        {
            var address = (long)(long*)((byte*)baseAddress + 30);
            System.Console.WriteLine($"AAA: {address}");
            SuitRefiner = new Refiner(address);

            if (address != 100)
            {
                logger.WriteLine($"[For CheatEngine Users] Suit Refiner address: {address.ToString("X")}");
            }
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
