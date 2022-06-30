using libMBIN;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System.Linq;

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

        GcPlanetData planetData;
        GcSolarSystemData solarSystemData;
        MemoryManager mgr;
        long planet1Address = 0;
        public Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            Game.ModsWarning.Disable();


            

#if DEBUG
            Game.OnMainMenu += OnMainMenu;
            Testing();

            Game.CurrentSystem.OnPlanetLoaded += (planetAddress) =>
            {
                string planetName = memory.GetValue<string>(planetAddress);
                Logger.WriteLine($"Loaded Planet: {planetName} at {planetAddress.ToHex()}");
            };
#endif
        }

        private void Testing()
        {
            
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

        bool done = false;
        public override void Update()
        {
            if (GalaxyMap.IsOpened)
            {
                Logger.WriteLine(true);
            }
            if (!done && Keyboard.IsPressed(Key.UpArrow))
            {
                Logger.WriteLine("Printing all managed mbins");
                var mbins = Game.MBinManager.GetAllMBIN();
                foreach (var mbin in mbins)
                {
                    Logger.WriteLine($"Name: {mbin.Name} | Address: {mbin.Address}");
                }

                done = true;
            }
            if (Keyboard.IsPressed(Key.Numpad0))
            {
                done = false;
            }
        }
#endif

        internal static void WriteLine(string message) => Instance?.Logger?.WriteLine(message);
        internal static void WriteLine(object message) => Instance?.Logger?.WriteLine(message);
    }
}