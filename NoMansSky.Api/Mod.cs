using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public class Mod : NMSMod
    {
        public unsafe Mod(Game _game, IModConfig _config, IReloadedHooks _hooks, ILogger _logger) : base(_game, _config, _hooks, _logger)
        {
            

            /*_game.Player.OnHealthChanged.Prefix += (amountChanged) =>
            {
                Logger.WriteLine($"health reduced by {amountChanged}.");
            };
            _game.Player.OnHealthChanged.Postfix += (amountChanged) =>
            {
                Logger.WriteLine($"Health is now {game.Player.GetHealth()}");
            };*/
        }

        bool isKeyPressed = false;
        public unsafe override void Update()
        {
            /*if (!isKeyPressed && Keyboard.IsPressed(Key.UpArrow))
            {
                Logger.WriteLine($"{game.Player.GetShieldHealth()}" +
                    $", {game.Player.GetHealth()}" +
                    $", {game.Player.GetUnits()}" +
                    $", {game.Player.GetNanites()}" +
                    $", {game.Player.GetQuicksilver()}");

                isKeyPressed = true;
            }
            else if (isKeyPressed && !Keyboard.IsPressed(Key.UpArrow))
            {
                isKeyPressed = false;
            }*/
        }
    }
}