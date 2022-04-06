using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System;
using System.Linq;

namespace NoMansSky.Api
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public class Mod : NMSMod
    {
        public unsafe Mod(Game _game, IModConfig _config, IReloadedHooks _hooks, ILogger _logger) : base(_game, _config, _hooks, _logger)
        {
            
        }

        bool isKeyPressed = false;
        public unsafe override void Update()
        {
            if (!isKeyPressed && Keyboard.IsPressed(Key.UpArrow))
            {
                isKeyPressed = true;

                var items = game.Player?.Exosuit?.GetInventory()?.GetItems();
                if (items == null)
                    return;

                // code here for on press but not on held.

            }
            else if (isKeyPressed && !Keyboard.IsPressed(Key.UpArrow))
            {
                isKeyPressed = false;
            }
        }
    }
}