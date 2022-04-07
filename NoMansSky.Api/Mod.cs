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
            var exosuit = _game.Player.Exosuit;
            _game.OnProfileSelected += () =>
            {
                /*var inventory = exosuit.GetInventory();
                var items = inventory.GetItems();
                Logger.WriteLine($"ItemCount: {items.Count}");
                for (int i = 0; i < items.Count; i++)
                {
                    var item = items[i];
                    Logger.WriteLine(item.GetItemId());
                }

                var stellar = items.FirstOrDefault(item => item.GetItemId() == "STELLAR2");
                stellar.SetQuantity(20);
                stellar.SetMaxQuantity(20);
                stellar.SetItemId("TECH_COMP");
                stellar.SetItemType(GcInventoryType.Product);

                Logger.WriteLine($"----------------------------------");
                Logger.WriteLine($"NewItemID: {stellar.GetItemId()}");

                items = inventory.GetItems();
                foreach (var item in items)
                {
                    Logger.WriteLine(item.GetItemId());
                }*/
            };
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