using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents an instance of GcSpaceSkyColourSettingList
    /// </summary>
    public class SpaceColors : ISpaceColors
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<ISpaceColorSetting> OnColorLoaded { get; set; } = new SharedModEvent<ISpaceColorSetting>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ISpaceColorSetting DefaulColorSettings { get; set; } = new SpaceColorSetting();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ISpaceColorSetting RareColorSettings { get; set; } = new SpaceColorSetting();

        public unsafe SpaceColors()
        {
            IGame.Instance.MBinManager.OnMBinLoaded.AddListener(mbin =>
            {
                if (mbin.MBinName == "SPACESKYCOLOURS")
                {
                    DefaulColorSettings.MBin = mbin;
                    DefaulColorSettings.OnLoaded.Invoke();
                    OnColorLoaded.Invoke(DefaulColorSettings);
                }
                else if (mbin.MBinName == "SPACERARESKYCOLOURS")
                {
                    RareColorSettings.MBin = mbin;
                    RareColorSettings.OnLoaded.Invoke();
                    OnColorLoaded.Invoke(RareColorSettings);
                }
            });
        }
    }
}
