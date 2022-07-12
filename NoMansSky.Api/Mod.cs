using libMBIN;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Globals;
using libMBIN.NMS.Toolkit;
using Newtonsoft.Json;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
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


        public Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            Game.ModsWarning.Disable();


#if DEBUG

            Game.Globals.PlayerGlobals.Modify<GcPlayerGlobals>(playerGlobals =>
            {
                playerGlobals.GroundRunSpeed *= 2;
            });

            /*MBinManager.OnMBinLoaded.AddListener(mbin =>
            {
                if (mbin.Name != "ProjectileTable")
                    return;

                Logger.WriteLine("Found ProjectileTable");
                mbin.Modify<GcProjectileDataTable>(dataTable =>
                {
                    foreach (var item in dataTable.Table)
                    {
                        item.BounceDamping = 0;
                        item.DefaultDamage = 0;
                        item.ExtraPlayerDamage = 0;
                        item.PiercingDamagePercentage = 0;
                    }
                });
            });*/


            CurrentSystem.OnPlanetLoaded.AddListener(loadedPlanet =>
            {
                loadedPlanet.ModifyPlanetData(planetData =>
                {
                    foreach (var creatureData in planetData.SpawnData.Creatures)
                    {
                        creatureData.MaxScale = 15;
                        creatureData.MinScale = 10;
                    }
                });
            });


            Game.OnMainMenu.AddListener(() =>
            {
                
            });


            /*Game.Reality..OnLoaded.AddListener(() =>
            {
                Game.Reality.DefaultReality.Modify(obj =>
                {
                    obj.TradeSettings.Shop.
                });

                Logger.WriteLine("Done modding costs");
            });*/

#endif
        }

        protected override void Awake()
        {
            base.Awake();
            Instance = this;
        }

#if DEBUG

        public override void Update()
        {
            /*if (!Game.IsInGame)
                return;*/

           
            if (Keyboard.IsPressed(Key.Numpad5))
            {
                string xmlPath = $"{MyModFolder}\\CreatureDataTable.json";
                //var test = NMSTemplate.TemplateFromName("GcSolarSystemSkyColourData");
                //test.WriteToExml(xmlPath, true);

                var creatures = Game.Creatures.CreatureDataTable.GetValue();
                var global = Game.Globals.AISpaceshipGlobals.GetValue<GcAISpaceshipGlobals>();
                string json = JsonConvert.SerializeObject(creatures, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(xmlPath, json);
            }
        }
#endif
    }
}