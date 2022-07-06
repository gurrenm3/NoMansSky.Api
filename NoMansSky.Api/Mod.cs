using libMBIN;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Globals;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using static libMBIN.NMS.GameComponents.GcAudioWwiseEvents;
using Random = Reloaded.ModHelper.Random;

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
#endif
        }

        protected override void Awake()
        {
            base.Awake();
            Instance = this;
        }

#if DEBUG

        private void OnMainMenu()
        {
            /*foreach (var item in Game.MBinManager.GetAllMBIN())
            {
                Logger.WriteLine($"MbinName: {item.Name} |  Address: {item.Address}");
            }*/
        }

        public override void OnGameJoined()
        {
            /*var files = Game.EnvironmentObjects;
            foreach (var file in files)
            {
                Logger.WriteLine($"Name: {file.MBinName} | Address: {file.Address.ToHex()}");

            }*/
        }

        public async override void Update()
        {
            if (!Game.IsInGame)
                return;

            if (Keyboard.IsPressed(Key.UpArrow))
            {
                
            }
        }

        private void PrintInventory()
        {
            var inventory = Player.Exosuit.GetInventory();
            Logger.WriteLine($"\n{inventory}");
        }

        

#endif

        internal static void WriteLine(string message) => Instance?.Logger?.WriteLine(message);
        internal static void WriteLine(object message) => Instance?.Logger?.WriteLine(message);
    }
}