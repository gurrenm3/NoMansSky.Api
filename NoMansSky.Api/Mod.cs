using libMBIN;
using libMBIN.NMS;
using libMBIN.NMS.Globals;
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
        /// <summary>
        /// Used for logging messages within the api. Not necessary for your mods.
        /// </summary>
        internal static Mod Instance { get; private set; }

        // This is an example of a mod setting.
        //ModSettingInt startingUnits = new ModSettingInt(9999999);

        public Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            Game.ModsWarning.Disable();
            Game.OnMainMenu += OnMainMenu;
            /*Game.OnMainMenu += () => GlobalMbinModding();
            */
        }

        private void OnMainMenu()
        {
            playerGlobalsAddress = Game.MBinManager.GetMbin("GcPlayerGlobals").Address;

            /*float x = memoryMgr.GetValue<float>("GcPlayerGlobals.BinocularScopeOffset.x");
            float y = memoryMgr.GetValue<float>("GcPlayerGlobals.BinocularScopeOffset.y");
            float z = memoryMgr.GetValue<float>("GcPlayerGlobals.BinocularScopeOffset.z");
            Logger.WriteLine($"({x}, {y}, {z})");*/

            /*Vector3f scopeOffset = memoryMgr.GetValue<Vector3f>("GcPlayerGlobals.BinocularScopeOffset");
            Logger.WriteLine($"({scopeOffset.x}, {scopeOffset.y}, {scopeOffset.z})");

            Logger.WriteLine("Address: " + Game.MBinManager.GetMbin("GcPlayerGlobals").Address.ToHex());
            var offset = NMSTemplate.OffsetOf("GcPlayerGlobals", "BinocularScopeOffset");
            Logger.WriteLine($"Offset {offset}");*/

            //memoryMgr.SetValue("GcPlayerGlobals.GroundRunSpeed", currentValue + 1);
        }


        protected override void Awake()
        {
            base.Awake();
            Instance = this;
        }


        private void PrintInventory()
        {
            var inventory = Player.Exosuit.GetInventory();
            Logger.WriteLine($"\n{inventory}");
        }


        long playerGlobalsAddress = 0;
        public async override void Update()
        {
            if (Keyboard.IsPressed(Key.RightArrow))
            {
                MemoryManager memoryMgr = new MemoryManager();
                
                var global = await memoryMgr.GetValueAsync<GcPlayerGlobals>(playerGlobalsAddress);
                global.GroundRunSpeed += 1;
                await memoryMgr.SetValueAsync(playerGlobalsAddress, global);
                Logger.WriteLine("Done setting global");
                //memoryMgr.SetValue("GcPlayerGlobals.BinocularRangeSpace", 69);
            }
            /*if (Keyboard.IsPressed(Key.UpArrow))
            {
                Logger.WriteLine("Up arrow pressed. Raising sprint speed by 1");

                globalMbin.GroundRunSpeed += 1;
                memoryMgr.SetValue(variableAddress, globalMbin.GroundRunSpeed);
            }
            if (Keyboard.IsPressed(Key.DownArrow))
            {
                Logger.WriteLine("Down arrow pressed. Reducing sprint speed by 1");

                globalMbin.GroundRunSpeed -= 1;
                memoryMgr.SetValue(variableAddress, globalMbin.GroundRunSpeed);
            }*/
        }

        internal static void WriteLine(string message) => Instance?.Logger?.WriteLine(message);
        internal static void WriteLine(object message) => Instance?.Logger?.WriteLine(message);
    }
}