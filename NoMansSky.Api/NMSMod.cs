using HarmonyLib;
using Reloaded.Hooks.Definitions;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System.Drawing;

namespace NoMansSky.Api
{
    /// <summary>
    /// A base class for No Man's Sky mods.
    /// </summary>
    public class NMSMod : ReloadedMod
    {
        /// <summary>
        /// An instance of Harmony, specifically for this mod. Used to HarmonyPatch.
        /// </summary>
        public Harmony HarmonyLib { get; protected set; }

        /// <summary>
        /// Instance of the game loop.
        /// </summary>
        public Game game { get; private set; }

        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        public NMSMod(Game _game, IModConfig _config, IReloadedHooks _hooks, ILogger _logger) : base(_config, _hooks, _logger)
        {
            game = _game;

            InitHarmony();

            game.OnUpdate.Postfix += Update;
        }

        /// <summary>
        /// Called once every time the game loop runs.
        /// </summary>
        public virtual void Update() { }

        /// <summary>
        /// Called when this mod's Harmony Instance is created. Override it to change how it's made.
        /// </summary>
        /// <returns></returns>
        public virtual Harmony CreateHarmonyInstance()
        {
            string harmonyId = $"{ModConfig.ModAuthor.Replace(" ", "_")}.{ModConfig.ModName.Replace(" ","_")}";
            return new Harmony(harmonyId);
        }

        private void InitHarmony()
        {
            HarmonyLib = CreateHarmonyInstance();

            var assembly = AssemblyUtils.GetCallingAssembly();
            HarmonyLib.PatchAll(assembly);
            Logger.Write("Harmony instance created with id:  ", insertModName:true);
            Logger.Write($"\"{HarmonyLib.Id}\"", Color.RosyBrown);
            Logger.Write($"\n");
        }
    }
}
