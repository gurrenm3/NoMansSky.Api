using Reloaded.Hooks.Definitions;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;

namespace NoMansSky.Api
{
    /// <summary>
    /// A base class for No Man's Sky mods.
    /// </summary>
    public class NMSMod : ReloadedMod
    {
        /// <summary>
        /// Instance of the game loop.
        /// </summary>
        public Game game { get; private set; }

        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        public NMSMod(Game _game, IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            game = _game;
            game.OnUpdate.Postfix += Update;
        }

        /// <summary>
        /// Called once every time the game loop runs.
        /// </summary>
        public virtual void Update() { }
    }
}
