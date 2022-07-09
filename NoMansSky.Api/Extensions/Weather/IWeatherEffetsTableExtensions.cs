using libMBIN.NMS.GameComponents;
using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="IWeatherEffectTable"/>.
    /// </summary>
    public static class IWeatherEffectTableExtensions
    {
        private static MemoryManager memory = new MemoryManager();

        /// <summary>
        /// Returns the actual GcWeatherEffectTable that this object is representing.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static GcWeatherEffectTable GetValue(this IWeatherEffectTable instance)
        {
            return memory.GetValue<GcWeatherEffectTable>(instance.MBin.Address);
        }

        /// <summary>
        /// Sets the value of this GcWeatherEffectTable and applies the changes back to the game.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="valueToSet"></param>
        public static void SetValue(this IWeatherEffectTable instance, GcWeatherEffectTable valueToSet)
        {
            memory.SetValue(instance.MBin.Address, valueToSet);
        }

        /// <summary>
        /// Provides a simpler way to load the GcWeatherEffectTable from memory, modify it, and apply the changes
        /// back to the game.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="modifyAction"></param>
        public static void Modify(this IWeatherEffectTable instance, Action<GcWeatherEffectTable> modifyAction)
        {
            var table = instance.GetValue();
            modifyAction?.Invoke(table);
            instance.SetValue(table);
        }
    }
}
