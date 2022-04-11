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
        public unsafe Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            Game.OnMainMenu += () => Logger.WriteLine("Reached Main Menu");
            Game.OnGameJoined += () => Logger.WriteLine("Game Joined");

            Player.Quicksilver.OnValueChanged.Prefix += (newVal) =>
            {
                Logger.WriteLine($"Quicksilver is changing to {newVal}. Setting it to 1234567 instead");
                newVal.value = 1234567;
            };
        }
        
        public override void Update()
        {
            if (Keyboard.IsPressed(Key.UpArrow))
            {

            }
        }
    }
}