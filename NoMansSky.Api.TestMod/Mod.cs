using NoMansSky.Api;
using NoMansSky.Api.Definitions;
using NoMansSky.Api.TestMod.Configuration;
using Reloaded.ModHelper;

namespace NoMansSky.Api.TestMod
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public unsafe class Mod : NMSMod
    {
        internal static Mod Instance { get; private set; }

        /// <summary>
        /// Provides access to this mod's configuration.
        /// </summary>
        public Config Configuration { get; set; }

        public Mod(ModContext context) : base(context)
        {
            Instance = this; // don't touch this
        }

        public override void Update()
        {
            if (Keyboard.IsPressed(Key.UpArrow))
            {

            }
            if (Keyboard.IsPressed(Key.DownArrow))
            {

            }
        }


        #region Standard Overrides

        // Attaches debugger to allow your mod to run with breakpoints.
        protected override bool EnableDebugger => false;

        public void ConfigurationUpdated(Config configuration)
        {
            // Apply settings from configuration.
            // ... your code here.
            Configuration = configuration;
            Logger.WriteLine($"[{ModConfig.ModId}] Config Updated: Applying");
        }
        #endregion

        #region For Exports, Serialization etc.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Mod() { }
#pragma warning restore CS8618
        #endregion

        internal static void WriteLine(string text) => Instance.Logger.WriteLine(text);
        internal static void WriteLine(object text) => Instance.Logger.WriteLine(text);
    }
}