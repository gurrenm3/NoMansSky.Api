﻿using libMBIN;
using libMBIN.NMS;
using libMBIN.NMS.Globals;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;

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
            Game.OnMainMenu += OnMainMenu;
        }

        private void OnMainMenu()
        {
            
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


        long playerGlobalsAddress = 0;
        public async override void Update()
        {
            if (Keyboard.IsPressed(Key.UpArrow))
            {
                
            }
        }

        internal static void WriteLine(string message) => Instance?.Logger?.WriteLine(message);
        internal static void WriteLine(object message) => Instance?.Logger?.WriteLine(message);
    }
}