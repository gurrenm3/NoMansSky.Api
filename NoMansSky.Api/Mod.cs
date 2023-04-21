using NoMansSky.Api;
using NoMansSky.Api.Configuration;
using NoMansSky.Api.Definitions;
using Reloaded.ModHelper;

namespace NoMansSky.Api
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



        #region Standard Overrides

// Attaches debugger to allow your mod to run with breakpoints.
#if DEBUG
        protected override bool EnableDebugger => true;
#endif

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


        internal static void WriteLine(object message, LogLevel logLevel = LogLevel.Normal) => WriteLine(message?.ToString(), logLevel);
        internal static void WriteLine(string message, LogLevel logLevel = LogLevel.Normal) => Instance.Logger.WriteLine(message, logLevel);
    }
}