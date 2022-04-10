using NoMansSky.Api.Hooks.PlayerHooks;
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
            Game.OnProfileSelected += () => Player.Health.Value = -10;
            Game.OnGameJoined += () => Logger.WriteLine("Game Joined");
        }

        int count = 0;
        public override void Update()
        {
            /*if (Keyboard.IsPressed(Key.UpArrow))
            {
                Logger.WriteLine("Up arrow pressed");
            }*/
        }
    }
}