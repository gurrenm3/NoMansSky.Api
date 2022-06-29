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
        MemoryManager mgr;
        long planet1Address = 0;
        public Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            Game.ModsWarning.Disable();

            
#if DEBUG
            Game.OnMainMenu += OnMainMenu;
            Testing();
#endif
        }

        private void Testing()
        {
            mgr = new MemoryManager();
            GameLoop.OnUpdate.Postfix += () =>
            {
                if (Key.UpArrow.IsPressed())
                {
                    var planets = Hooks.GalaxyMapHooks.Planet_Update.planetAddresses;
                    planet1Address = planets.First();
                    planetData = mgr.GetValue<GcPlanetData>(planet1Address);
                }
                if (Key.DownArrow.IsPressed())
                {
                    string planetText = planetData.AsString();
                    Logger.WriteLine(planetText);
                }
                if (Key.RightArrow.IsPressed())
                {
                    Logger.WriteLine("Setting entire planet");
                    mgr.SetValue(planet1Address, planetData);
                    Logger.WriteLine("Planet set");
                }
            };

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

        public override void Update()
        {
            
        }
#endif

        internal static void WriteLine(string message) => Instance?.Logger?.WriteLine(message);
        internal static void WriteLine(object message) => Instance?.Logger?.WriteLine(message);
    }
}