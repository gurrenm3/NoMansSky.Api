using libMBIN;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Globals;
using libMBIN.NMS.Toolkit;
using NoMansSky.Api.Hooks.GalaxyMap;
using NoMansSky.Api.Hooks.Mbin;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using System;
using Reloaded.ModHelper;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using static libMBIN.NMS.GameComponents.GcAudioWwiseEvents;
using Random = Reloaded.ModHelper.Random;
using static libMBIN.NMS.Toolkit.TkNoiseGridData;
using System.Collections.Generic;

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

            GcSpaceSkyColourSettingList g;
            GcWeatherEffectTable wt;
            GcWeatherEffectLightningData ld;

#if DEBUG
            Game.OnMainMenu += OnMainMenu;

            GcAISpaceshipGlobals ag;

            /*Game.WeatherData.WeatherEffects.OnLoaded.AddListener(() =>
            {
                Logger.WriteLine(Game.WeatherData.WeatherEffects.MBin);
            });*/

           /* MBinManager.OnMBinLoaded.AddListener(mbin =>
            {
                if (mbin.FullName != "UI/HUD/HUDHEALTH.MBIN")
                    return;

                Logger.WriteLine(mbin);

                var hudHealth = GetValue<GcNGuiLayerData>(mbin.Address);
                hudHealth.ElementData.Layout.Width = Random.Range(300, 6000);

                SetValue(mbin.Address, hudHealth);

                Logger.WriteLine("DONE");
            });*/
#endif
        }

        List<string> mbins = new List<string>();

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


            if (!Keyboard.IsPressed(Key.UpArrow))
                return;

            GcSolarSystemData sd;
            GcPlanetData d;
            GcCreatureMovementData f;
            GcDefaultSaveData s;
            var mbin = MBinManager.GetMBin("CREATUREDATATABLE");
            Logger.WriteLine(mbin);
            await MBinManager.ModifyMBinAsync<GcCreatureDataTable>("CREATUREDATATABLE", creatureData =>
            {
                foreach (var item in creatureData.Table)
                {
                    item.MinScale = 3f;
                    item.MaxScale = 8f;

                    item.FurLengthModifierAtMinScale = 5;
                    item.FurLengthModifierAtMaxScale = 8;


                    foreach (var data in item.Data)
                    {
                        Logger.WriteLine(data.GetType().Name);
                    }
                }

                Logger.WriteLine("Done modding voxel");
            });
            
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