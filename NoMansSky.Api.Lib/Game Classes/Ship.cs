using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    public class Ship
    {
        /// <summary>
        /// Called whenever the value of the Ship's health changes.
        /// <br/>The parameter is the amount that the health changed.
        /// </summary>
        public IModEventHook<float> OnHealthChanged { get; set; }

        /// <summary>
        /// Called whenever the value of the Ship's shield changes.
        /// <br/>The parameter is the amount that the shield changed.
        /// </summary>
        public IModEventHook<float> OnShieldChanged { get; set; }


        [Initialize]
        private static void Initialize()
        {

        }
    }
}
