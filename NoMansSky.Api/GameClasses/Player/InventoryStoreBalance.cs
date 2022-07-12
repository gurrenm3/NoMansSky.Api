using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an object from the GcInventoryBalance class
    /// </summary>
    internal class InventoryStoreBalance : IInventoryStoreBalance
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent OnLoaded { get; set; } = new SharedModEvent();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IMBin MBin { get; private set; }

        public InventoryStoreBalance()
        {
            IGame.Instance.MBinManager.OnMBinLoaded.AddListener(mbin =>
            {
                if (mbin.Name.ToLower() == "defaultinventorybalance")
                {
                    MBin = mbin;
                    OnLoaded.Invoke();
                }
            });
        }
    }
}
