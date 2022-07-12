using libMBIN.NMS.GameComponents;
using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="IInventoryStoreBalance"/>.
    /// </summary>
    public static class IInventoryStoreBalanceExtensions
    {
        /// <summary>
        /// Returns the actual GcInventoryStoreBalance that this object is representing.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static GcInventoryStoreBalance GetValue(this IInventoryStoreBalance instance)
        {
            return instance.MBin.GetValue<GcInventoryStoreBalance>();
        }

        /// <summary>
        /// Sets the value of this GcInventoryStoreBalance and applies the changes back to the game.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="valueToSet"></param>
        public static void SetValue(this IInventoryStoreBalance instance, GcInventoryStoreBalance valueToSet)
        {
            instance.MBin.SetValue(valueToSet);
        }

        /// <summary>
        /// Provides a simpler way to load the GcInventoryStoreBalance from memory, modify it, and apply the changes
        /// back to the game.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="modify"></param>
        public static void Modify(this IInventoryStoreBalance instance, Action<GcInventoryStoreBalance> modify)
        {
            var balance = instance.GetValue();
            modify?.Invoke(balance);
            instance.SetValue(balance);
        }
    }
}
