using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public unsafe class Mod : NMSMod
    {
        public Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            /*Game.OnMainMenu += () => Logger.WriteLine("Reached Main Menu");
            Game.OnGameJoined += () => Logger.WriteLine("Game Joined");

            Player.Quicksilver.OnValueChanged.Prefix += (newVal) =>
            {
                Logger.WriteLine($"Quicksilver is changing to {newVal}. Setting it to 1234567 instead");
                newVal.value = 1234567;
            };*/

            /*Game.OnProfileSelected += () =>
            {
                Logger.WriteLine("AAA");
                *//*foreach (var mbin in Game.MBinManager.GetAllMBIN())
                {
                    Logger.WriteLine($"{mbin.Name}: {mbin.Address.ToString("X")}");
                }*//*
            };*/
        }

        public override void Update()
        {
            if (Keyboard.IsPressed(Key.UpArrow))
            {
                Logger.WriteLine(Exosuit.SuitRefiner.Input.GetQuantity());

                /*var address = (long)((long*)Exosuit.SuitRefiner.Address + 30);

                var input = (GcInventoryElement*)address;
                Logger.WriteLine(input->amount);*/
            }
        }
    }
}