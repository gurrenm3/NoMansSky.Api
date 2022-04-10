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
        public Mod(Game _game, IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_game, _config, _hooks, _logger)
        {
            _game.Player.Shield.OnValueChanged.Prefix += (newValue) =>
            {
                Logger.WriteLine($"Current shield is {_game.Player.Shield.Value}." +
                    $" Shield changed by {_game.Player.Shield.Value - newValue}. Added 10 to shield");
                //newValue += 10;
            };
        }

        public override void Update()
        {
            //Logger.WriteLine("Update from test mod!");
        }
    }
}