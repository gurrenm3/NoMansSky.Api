using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NoMansSky.Api.GameClasses.Inventory.NewInventory;
using NoMansSky.Api.Hooks;
using NoMansSky.Api.libMBIN.Globals;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
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

        //GcPlayerStateData_Internal playerState;

        public Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            Game.ModsWarning.Disable();
            (MBinManager as MBinManager)?.LoadPakFiles($"{GameDataDirectory}\\PCBANKS");



            MBinManager.OnMBinLoaded.AddListener(mbin =>
            {
                Logger.WriteLine($"{mbin.FullName}   was loaded");
            });
#if DEBUG



            /*playerState = new GcPlayerStateData_Internal(0);

            int count = 0;
            foreach (var item in playerState.GetType().GetProperties())
            {
                var attributes = item.GetCustomAttributes<FindOffsetAttribute>();
                if (attributes == null || !attributes.Any())
                    continue;

                count++;
                //Logger.WriteLine($"Found attribute {}");
            }

            Logger.WriteLine($"There are {count} FindOffset properties in GcPlayerStateData_Internal");*/


            //Game.Player.OnPlayerStateAquired.AddListener(address => playerState = new(address));
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

            if (Keyboard.IsPressed(Key.UpArrow))
            {
                var mbin = MBinManager.GetMBin<GcAISpaceshipGlobals>();
                if (mbin == null)
                {
                    Logger.WriteLine($"Failed to get global :(");
                    return;
                }


                var playerGlobals = (GcAISpaceshipGlobals*)mbin.Address;
                Logger.WriteLine(playerGlobals->WarpArriveEffectIDs.Count);
                for (int i = 0; i < 7; i++)
                {
                    var item = playerGlobals->WarpArriveEffectIDs[i];
                    Logger.WriteLine(item->Value);
                }


                /*var inventory = new GameClasses.Inventory.NewInventory.Inventory(playerState.Inventory.address);
                var unlockedSlots = inventory.GetSlots();

                Stopwatch s = new Stopwatch();
                int numTests = 1000;

                s.Start();
                for (int i = 0; i < numTests; i++)
                {
                    unlockedSlots = inventory.GetSlots();
                }
                s.Stop();

                Logger.WriteLine($"NonParallel - Total time: {s.Elapsed.TotalSeconds}. Average: {s.Elapsed.TotalSeconds / numTests}");





                s.Restart();
                for (int i = 0; i < numTests; i++)
                {
                    unlockedSlots = inventory.GetSlotsParallel();
                }
                s.Stop();

                Logger.WriteLine($"Parallel - Total time: {s.Elapsed.TotalSeconds}. Average: {s.Elapsed.TotalSeconds / numTests}");

                return;
                
                var inUseSlots = unlockedSlots.FindAll(s => s.IsInUse());
                var unusedSlots = unlockedSlots.FindAll(s => !s.IsInUse());
                
                foreach (var slot in unlockedSlots)
                {
                    Logger.WriteLine($"({slot.X}, {slot.Y}) - IsUnlocked {slot.IsUnlocked().ToString().ToUpper()} - IsInUse {slot.IsInUse().ToString().ToUpper()}");
                }

                var slotToMove = inUseSlots.FirstOrDefault();
                var amount = slotToMove.HeldItem.Amount;
                Logger.WriteLine($"Slot at ({slotToMove.X}, {slotToMove.Y}). Address = {slotToMove.HeldItem.address.ToHex()} - Amount = {amount}");*/


                // figure out why this is broken!
                //Logger.WriteLine($"Slot at ({slotToMove.X}, {slotToMove.Y}). Address = {slotToMove.HeldItem.address} - ID = {slotToMove.HeldItem.Id} - Amount = {slotToMove.HeldItem.Amount}");

                /*var dest = Random.GetElement(unlockedSlots);
                Logger.WriteLine($"Moving from ({slotToMove.X}, {slotToMove.Y}) to slot at ({dest.X}, {dest.Y})");
                dest.SetItem(slotToMove.HeldItem);*/


            }
            if (Keyboard.IsPressed(Key.LeftArrow))
            {
                
            }
            if (Keyboard.IsPressed(Key.DownArrow))
            {
                
            }
        }

#endif

        internal static void WriteLine(object message, LogLevel logLevel = LogLevel.Normal) => WriteLine(message?.ToString(), logLevel);

        internal static void WriteLine(string message, LogLevel logLevel = LogLevel.Normal)
        {
            Instance.Logger.WriteLine(message, logLevel);
        }
    }
}