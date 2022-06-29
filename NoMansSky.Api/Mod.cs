using libMBIN;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Globals;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System.Diagnostics;

namespace NoMansSky.Api
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public class Mod : NMSMod
    {
        /// <summary>
        /// Used for logging messages within the api. Not necessary for your mods.
        /// </summary>
        internal static Mod Instance { get; private set; }

        // This is an example of a mod setting.
        //ModSettingInt startingUnits = new ModSettingInt(9999999);

        public Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            Game.ModsWarning.Disable();

            
            /*Game.GalaxyMap.OnSystemHighlighted += (systemInfo) =>
            {
                Logger.WriteLine("System Highlighted. Printing addresses:");
                foreach (var item in systemInfo.PlanetAddresses)
                {
                    Logger.WriteLine(item.ToHex());
                }

                Logger.WriteLine("Printing planet names:");
                var planets = systemInfo.GetPlanets();
                foreach (var planet in planets)
                {
                    Logger.WriteLine(planet.Name);
                }
                Logger.WriteLine("Done printing planet info");
            };*/

#if DEBUG
            Game.OnMainMenu += OnMainMenu;
#endif
        }

        private void OnMainMenu()
        {
            var memoryMgr = new MemoryManager();
            float currentRunSpeed = memoryMgr.GetValue<float>("GcPlayerGlobals.GroundRunSpeed");

            // example of settng the run speed to twice it's original value.
            memoryMgr.SetValue("GcPlayerGlobals.GroundRunSpeed", currentRunSpeed * 2);
        }


        protected override void Awake()
        {
            base.Awake();
            Instance = this;
        }


        private void PrintInventory()
        {
            var inventory = Player.Exosuit.GetInventory();
            Logger.WriteLine($"\n{inventory}");
        }


#if DEBUG
        
        /*MemoryManager memoryMgra = new MemoryManager();
        Stopwatch stopwatch = new Stopwatch();
        public override void Update()
        {
            if (Keyboard.IsHeld(Key.Shift))
            {
                if (stopwatch.Elapsed.TotalMilliseconds >= 5000)
                {
                    float currentRunSpeed = memoryMgra.GetValue<float>("GcPlayerGlobals.GroundRunSpeed");
                    if (currentRunSpeed < 30) { memoryMgra.SetValue("GcPlayerGlobals.GroundRunSpeed", currentRunSpeed * 1.25); }
                    currentRunSpeed = memoryMgra.GetValue<float>("GcPlayerGlobals.GroundRunSpeed");
                    Logger.WriteLine("current speed is ", (LogLevel)currentRunSpeed);
                }
            }

            else if (Keyboard.IsReleased(Key.Shift))
            {
                stopwatch.Stop();
                stopwatch.Restart();
                
            }
        }*/
#endif

        internal static void WriteLine(string message) => Instance?.Logger?.WriteLine(message);
        internal static void WriteLine(object message) => Instance?.Logger?.WriteLine(message);
    }
}