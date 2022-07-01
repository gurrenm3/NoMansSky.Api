using libMBIN;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Globals;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System.Collections.Generic;
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


            CurrentSystem.OnPlanetLoaded += (planetAddress) =>
            {
                var planet = CurrentSystem.GetPlanetData(planetAddress);
                Logger.WriteLine($"PlanetLoaded: {planet.Name.AsString()}");
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
            message = $"IsOnMainMenu = {Game.IsOnMainMenu} | Game.IsLoadingIntoGame = {Game.IsLoadingIntoGame} | Game.IsInGame = {Game.IsInGame} | GalaxyMap.IsOpened = {GalaxyMap.IsOpened} | Game.IsWarping = {Game.IsWarping}";

            if (message != lastMessage)
            {
                Logger.WriteLine(message);
                lastMessage = message;
            }
        }
#endif

        internal static void WriteLine(string message) => Instance?.Logger?.WriteLine(message);
        internal static void WriteLine(object message) => Instance?.Logger?.WriteLine(message);
    }
}