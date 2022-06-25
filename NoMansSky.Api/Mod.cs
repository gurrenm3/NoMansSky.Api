using libMBIN;
using libMBIN.NMS.Globals;
using libMBIN.NMS.Toolkit;
using MonoMod.Utils;
using NoMansSky.Api.Hooks.Mbin;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoMansSky.Api
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public unsafe class Mod : NMSMod
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
            Game.MBinManager.OnMBinLoaded += OnMbinLoaded;
        }

        private void OnMbinLoaded(IMBin mBin)
        {
            if (mBin.Name != nameof(GcAISpaceshipGlobals).Remove(0, 2))
                return;

            long currentAddress = mBin.Address;
            Logger.WriteLine(currentAddress.ToString("X"));

            var type = typeof(GcAISpaceshipGlobals);
            PrintFields(type, currentAddress);

            Logger.WriteLine("Done");
        }

        List<MemoryData> leftover = new List<MemoryData>();
        private void PrintFields(Type classType, long baseAddress)
        {
            var fields = classType.GetFields();
            for (int i = 0; i < fields.Length; i++)
            {
                var field = fields[i];
                var fieldType = field.FieldType;

                var offset = NMSTemplate.OffsetOf(classType, field.Name);
                var value = GetValue(fieldType, baseAddress + offset);

                if (value != null)  // it's a simple datatype
                {
                    string msg = string.Format("name= {0, -48} value= {1,-10}", field.Name, value);
                    Logger.WriteLine(msg);
                    continue;
                }

                // it's a complex datatype, likely has it's own fields.
                // The code below was used to prevent stack overflow from recursion.
                /*MemoryData data = new MemoryData()
                {
                    address = baseAddress + offset,
                    field = field,
                };
                leftover.Add(data); */

                PrintFields(fieldType, baseAddress);
            }
        }

        private object GetValue(Type dataType, long address)
        {
            if (dataType == typeof(bool))
                return *(bool*)address;
            if (dataType == typeof(byte))
                return *(byte*)address;
            if (dataType == typeof(int))
                return *(int*)address;
            if (dataType == typeof(long))
                return *(long*)address;
            if (dataType == typeof(float))
                return *(float*)address;
            if (dataType == typeof(decimal))
                return *(decimal*)address;
            if (dataType == typeof(double))
                return *(double*)address;
            if (dataType == typeof(string) || dataType == typeof(char*) || dataType.Name.ToLower().Contains("nmsstring"))
                return Strings.ToString(address);
            if (dataType.Name == "Vector2f")
            {
                var x = *(float*)address;
                var y = *(float*)(address + 0x4);
                return new Vector2(x, y);
            }
            if (dataType.Name == "Vector3f")
            {
                var x = *(float*)address;
                var y = *(float*)(address + 0x4);
                var z = *(float*)(address + 0x8);
                return new Vector3(x, y, z);
            }
            if (dataType.Name == "CurveEnum")
            {
                var enumName = Strings.ToString(*(char*)address);
                if (!string.IsNullOrEmpty(enumName))
                {
                    Enum.TryParse<TkCurveType.CurveEnum>(enumName, out var value);
                    return value;
                }
                else
                {
                    int id = *(int*)address;
                    try
                    {
                        return (TkCurveType.CurveEnum)id;
                    }
                    catch (Exception)
                    {
                        return id;
                    }
                }                
            }

            return null;
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

        public override void Update()
        {
            if (Keyboard.IsPressed(Key.UpArrow))
            {
                
            }
        }

        internal static void WriteLine(string message) => Instance?.Logger?.WriteLine(message);
        internal static void WriteLine(object message) => Instance?.Logger?.WriteLine(message);
    }
}