using libMBIN;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Globals;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System.Collections.Generic;
using System.Diagnostics;
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

        public Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            Game.ModsWarning.Disable();
            

#if DEBUG
            Game.OnMainMenu += OnMainMenu;
            Testing();

            


            bool done = false;
            CurrentSystem.OnPlanetLoaded += (planetAddress) =>
            {
                /*var planet = CurrentSystem.GetPlanetData(planetAddress);
                var data = planet.GenerationData;
                var dataStr = data.AsString();

                Logger.WriteLine("=================================");
                Logger.WriteLine($"Planet Name: {planet.Name.Value}\n{dataStr}");*/

                return;

                if (done)
                    return;

                //var planet = CurrentSystem.GetPlanetData(planetAddress);


                Stopwatch stopwatch = new Stopwatch();
                int testCount = 100;

                Logger.WriteLine("Testing GetPlanetData");
                stopwatch.Start();
                for (int i = 0; i < testCount; i++)
                {
                    var planet = memory.GetValue(planetAddress, typeof(GcPlanetData));
                }
                stopwatch.Stop();
                Logger.WriteLine($"After {testCount} tests, it takes an average of" +
                    $" {stopwatch.Elapsed.TotalMilliseconds / testCount}ms to GetPlanetData");


                Logger.WriteLine("Testing SetPlanetData");
                var planetData = CurrentSystem.GetPlanetData(planetAddress);
                stopwatch.Restart();
                for (int i = 0; i < testCount; i++)
                {
                    //CurrentSystem.SetPlanetData(planetAddress, planetData);
                }
                stopwatch.Stop();
                Logger.WriteLine($"After {testCount} tests, it takes an average of" +
                    $" {stopwatch.Elapsed.TotalMilliseconds / testCount}ms to SetPlanetData");



                Logger.WriteLine("Testing GetPlanetData and SetPlanetData");
                stopwatch.Restart();
                for (int i = 0; i < testCount; i++)
                {
                    /*var planet = CurrentSystem.GetPlanetData(planetAddress);
                    CurrentSystem.SetPlanetData(planetAddress, planet);*/
                }
                stopwatch.Stop();
                Logger.WriteLine($"After {testCount} tests, it takes an average of" +
                    $" {stopwatch.Elapsed.TotalMilliseconds / testCount}ms to GetPlanetData and SetPlanetData");




                done = true;
            };
#endif
        }

        

        private void Testing()
        {

        }

        private void OnMainMenu()
        {
            /*foreach (var item in Game.MBinManager.GetAllMBIN())
            {
                Logger.WriteLine($"MbinName: {item.Name} |  Address: {item.Address}");
            }*/
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

        string message = "";
        string lastMessage = "";

        public override void Update()
        {
            
        }
#endif

        internal static void WriteLine(string message) => Instance?.Logger?.WriteLine(message);
        internal static void WriteLine(object message) => Instance?.Logger?.WriteLine(message);
    }
}