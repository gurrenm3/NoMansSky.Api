using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an instance of GcSpaceSkyColourSettingList.
    /// </summary>
    public interface ISpaceColors
    {
        /// <summary>
        /// Called whenever a SpaceColorSetting file gets loaded by the game.
        /// </summary>
        public IModEvent<ISpaceColorSetting> OnColorLoaded { get; set; }

        /// <summary>
        /// Represents the default color settings used by the game.
        /// <br/>The equivalent of SPACESKYCOLOURS.MBIN
        /// </summary>
        public ISpaceColorSetting DefaulColorSettings { get; set; }

        /// <summary>
        /// Represents the rare color settings used by the game.
        /// <br/>The equivalent of SPACERARESKYCOLOURS.MBIN
        /// </summary>
        public ISpaceColorSetting RareColorSettings { get; set; }
    }
}
