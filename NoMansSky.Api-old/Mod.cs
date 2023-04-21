using Reloaded.Mod.Interfaces;
using Random = Reloaded.ModHelper.Random;

namespace NoMansSky.Api
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public unsafe class Mod : NMSMod
    {
        /// <summary>
        /// Used for logging messages within the api. Not necessary for your mods.
        /// </summary>
        internal static Mod Instance { get; private set; }

        public Mod(ModContext context) : base(context)
        {
            /*Game.ModsWarning.Disable();
            (MBinManager as MBinManager)?.LoadPakFiles($"{GameDataDirectory}\\PCBANKS");*/
        }

        /*public Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            Game.ModsWarning.Disable();
            (MBinManager as MBinManager)?.LoadPakFiles($"{GameDataDirectory}\\PCBANKS");
        }*/

        protected override void Awake()
        {
            base.Awake();
            Instance = this;
        }

        public override void Update()
        {
            /*if (!Game.IsInGame)
                return;*/


            if (Keyboard.IsPressed(Key.UpArrow))
            {
                
            }
            if (Keyboard.IsPressed(Key.LeftArrow))
            {
                
            }
            if (Keyboard.IsPressed(Key.DownArrow))
            {
                
            }
        }


        internal static void WriteLine(object message, LogLevel logLevel = LogLevel.Normal) => WriteLine(message?.ToString(), logLevel);

        internal static void WriteLine(string message, LogLevel logLevel = LogLevel.Normal)
        {
            Instance.Logger.WriteLine(message, logLevel);
        }
    }
}