using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a GcSpaceSkyColourSettingList mbin file.
    /// </summary>
    public interface ISpaceColorSetting
    {
        /// <summary>
        /// Called whenever this SpaceColorSetting file gets loaded.
        /// </summary>
        public IModEvent OnLoaded { get; set; }

        /// <summary>
        /// The MBin File associated with this ColorSetting
        /// </summary>
        public IMBin MBin { get; set; }
    }
}
