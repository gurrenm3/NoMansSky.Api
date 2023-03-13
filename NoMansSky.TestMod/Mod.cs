using NoMansSky.Api;
using Reloaded.Hooks.Definitions;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System;

namespace NoMansSky.TestMod
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public class Mod : NMSMod
    {
        public Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            /*Game.OnMainMenu.AddListener(() =>
            {
                
            });

            Player.Shield.OnValueChanged.Prefix += (newValue) =>
            {
                Logger.WriteLine($"Current shield is {Player.Shield.Value}." +
                    $" Shield changed by {Player.Shield.Value - newValue}.");
            };*/
        }

        public override void Update()
        {
            //Logger.WriteLine("Update from test mod!");
        }
    }
}