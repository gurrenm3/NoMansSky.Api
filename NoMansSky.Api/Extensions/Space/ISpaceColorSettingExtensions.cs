using libMBIN.NMS.GameComponents;
using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="ISpaceColorSetting"/>
    /// </summary>
    public static class ISpaceColorSettingExtensions
    {
        private static MemoryManager memory = new MemoryManager();

        /// <summary>
        /// Returns the GcSpaceSkyColourSettingList associated with this ColorSetting.
        /// </summary>
        /// <param name="colorSetting"></param>
        /// <returns></returns>
        public static GcSpaceSkyColourSettingList GetValue(this ISpaceColorSetting colorSetting)
        {
            return memory.GetValue<GcSpaceSkyColourSettingList>(colorSetting.MBin.Address);
        }

        /// <summary>
        /// Sets the ColorSettings for this Colour Setting List.
        /// </summary>
        /// <param name="colorSetting"></param>
        /// <param name="valueToSet"></param>
        public static void SetValue(this ISpaceColorSetting colorSetting, GcSpaceSkyColourSettingList valueToSet)
        {
            memory.SetValue(colorSetting.MBin.Address, valueToSet);
        }

        /// <summary>
        /// Provides a simpler way to load the current PlanetData from memory, modify it, and apply the changes
        /// back to the game.
        /// </summary>
        /// <param name="colorSetting"></param>
        /// <param name="modifyAction"></param>
        public static void Modify(this ISpaceColorSetting colorSetting, Action<GcSpaceSkyColourSettingList> modifyAction)
        {
            var settings = colorSetting.GetValue();
            modifyAction?.Invoke(settings);
            colorSetting.SetValue(settings);
        }
    }
}
