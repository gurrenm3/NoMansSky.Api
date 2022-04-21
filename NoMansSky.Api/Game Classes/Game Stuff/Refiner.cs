using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a refiner.
    /// </summary>
    public unsafe class Refiner : IRefiner
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public long Address => _address;
        private long _address;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public InventoryItem Fuel { get; set; } = null!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public InventoryItem Input { get; set; } = null!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public InventoryItem Output { get; set; } = null!;


        /// <summary>
        /// Creates an instance of this class along with the address of the actual suit refiner in memory.
        /// </summary>
        /// <param name="address"></param>
        public Refiner(long address)
        {
            this._address = address;

            //Fuel = new InventoryItem(address);

            //var inputAddress = (long)(long*)address + 30;

            //var inputAddress = *(long*)(address + 100);
            //System.Console.WriteLine($"inputAddress: {inputAddress}");

            var inputAddress = (long)(long*)((byte*)address + 30);
            Input = new InventoryItem(inputAddress); // Offset of 30 because there are 30 bytes between each item
            //Output = new InventoryItem(address + 60);
        }
    }
}
