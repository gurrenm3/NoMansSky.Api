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
        public unsafe Mod(Game _game, IModConfig _config, IReloadedHooks _hooks, ILogger _logger) : base(_game, _config, _hooks, _logger)
        {
            _game.OnMainMenu += () => Logger.WriteLine("Reached Main Menu");
            _game.OnGameJoined += () => Logger.WriteLine("Game Joined");
        }

        int count = 0;
        public override void Update()
        {
            /*if (Keyboard.IsPressed(Key.UpArrow))
            {

            }*/
        }
    }
}