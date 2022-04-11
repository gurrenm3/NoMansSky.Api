using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// A custom attribute that can be used to turn a Property or Field into a Mod Setting.
    /// </summary>
    public class ModSettingAttribute : ModPropertyFieldAttribute
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void OnAttributeLoaded()
        {
            
        }
    }
}
