﻿using libMBIN;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Globals;
using libMBIN.NMS.Toolkit;
using MonoMod.Utils;
using NoMansSky.Api.Hooks.Mbin;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Automation.Peers;

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



            



            Game.OnProfileSelected += () =>
            {
                var address = Player.GcPlayerStateAddress;
                var inventoryAddress = address += 0x568;

                inventoryAddress += 0x30; // Offset of 30 because there are 30 bytes between each item 
                var mgr = new MemoryManager();
                var listType = typeof(List<libMBIN.NMS.GameComponents.GcInventoryElement>);
                IList inventory = (IList)mgr.GetValue(listType, inventoryAddress);
                if (inventory == null)
                {
                    Logger.WriteLine("Failed to load Item from memory");
                    return;
                }

                Logger.WriteLine($"Inventory Count: {inventory.Count}");

                foreach (libMBIN.NMS.GameComponents.GcInventoryElement item in inventory)
                {
                    Logger.WriteLine($"--------------------------------------");
                    Logger.WriteLine($"item.id: {item.Id.Value}");
                    Logger.WriteLine($"item.amount: {item.Amount}");
                    Logger.WriteLine($"item.maxAmount: {item.MaxAmount}");
                    Logger.WriteLine($"item.itemType: {item.Type.InventoryType}");
                    Logger.WriteLine($"item.index: ({item.Index.X}, {item.Index.Y})");
                }
            };
        }

        private void OnMbinLoaded(IMBin mBin)
        {
            /*// enum testing

            //var type = typeof(TkCurveType.CurveEnum);
            var type = typeof(GcAudioWwiseEvents.AkEventEnum);
            var underlyingType = type.GetEnumUnderlyingType();

            //var value = GcAudioWwiseEvents.AkEventEnum.ABANDONED_DOOR_UNLOCK;
            var enumId = 642510125u;

            foreach (var item in Enum.GetValues(type))
            {
                var enumAsUnderlyingType = Convert.ChangeType(item, underlyingType);
                if (enumAsUnderlyingType.Equals(enumId))
                {
                    //return Convert.ChangeType(value, enumType);
                    Logger.WriteLine(item);
                }
            }

            Logger.WriteLine("Done");
            //Logger.WriteLine(result);
            return;*/



            var mgr = new MemoryManager();


            // all mbin
            /*if (!mBin.Name.EndsWith("Globals"))
                return;
            long currentAddress = mBin.Address;
            Logger.WriteLine($"Address of {mBin.Name}: {currentAddress.ToString("X")}");

            var asm = typeof(GcAISpaceshipGlobals).Assembly;
            var globalTypes = asm.GetTypes().Where(t => t.Name.ToLower().EndsWith("globals"));
            var desiredType = globalTypes.FirstOrDefault(t => t.Name.Remove(0, 2) == mBin.Name);
            if (desiredType == null)
                return;

            var global = mgr.GetValue(desiredType, mBin.Address);
            Logger.WriteLine($"Loaded {mBin.Name}");*/


            // single mbin
            var desiredType = typeof(GcAISpaceshipGlobals);
            if (mBin.Name != desiredType.Name.Remove(0, 2))
                return;
            Logger.WriteLine(desiredType == null);
            if (desiredType == null)
                return;

            var global = (GcAISpaceshipGlobals)mgr.GetValue(desiredType, mBin.Address);
            Logger.WriteLine($"Loaded {mBin.Name}");


            foreach (var field in global.GetType().GetFields())
            {
                PrintFields(field.FieldType, field.GetValue(global));
            }
        }

        private void PrintFields(Type fieldType, object fieldValue)
        {
            if (fieldType.IsPrimitive || fieldType == typeof(decimal))
            {
                string msg = string.Format("name= {0, -48} value= {1,-10}", fieldType.Name, fieldValue);
                Logger.WriteLine(msg);
            }
            else if (fieldType.IsEnum)
            {
                var value = Enum.GetValues(fieldType).GetValue((int)fieldValue);
                string msg = string.Format("name= {0, -48} value= {1,-10}", fieldType.Name, value);
                Logger.WriteLine(msg);
            }
            else if (fieldType == typeof(string))
            {
                string msg = string.Format("name= {0, -48} value= {1,-10}", fieldType.Name, fieldValue);
                Logger.WriteLine(msg);
            }
            else if (fieldType.IsAssignableTo(typeof(INMSString)))
            {
                string value = ((INMSString)fieldValue).StringValue();
                string msg = string.Format("name= {0, -48} value= {1,-10}", fieldType.Name, value);
                Logger.WriteLine(msg);
            }
            else if (fieldType.IsArray)
            {
                Array array = (Array)fieldValue;
                foreach (var item in array)
                {
                    PrintFields(item.GetType(), item);
                }
            }
            else if (fieldType.IsAssignableTo(typeof(IList)))
            {
                IList list = (IList)fieldValue;
                foreach (var item in list)
                {
                    PrintFields(item.GetType(), item);
                }
            }
            else if (fieldType.IsAssignableTo(typeof(NMSTemplate)))
            {
                NMSTemplate template = (NMSTemplate)fieldValue;
                foreach (var field in template.GetType().GetFields())
                {
                    PrintFields(field.FieldType, field.GetValue(fieldValue));
                }
            }
        }



        /*private void PrintFields(Type classType, long baseAddress)
        {
            var fields = classType.GetFields();
            for (int i = 0; i < fields.Length; i++)
            {
                var field = fields[i];
                var fieldType = field.FieldType;
                var offset = NMSTemplate.OffsetOf(classType, field.Name);

                if (fieldType.IsArray)
                {
                    var arrayType = fieldType.GetElementType();
                    var objSize = NMSTemplate.SizeOf(arrayType);
                    int? arrSize = field.GetCustomAttribute<NMSAttribute>()?.Size;
                    Logger.WriteLine($"Array type: {arrayType?.Name} | Array Length: {arrSize} | Object Size: {objSize}");

                    if (arrSize == null)
                        continue;

                    var array = new object[arrSize.Value];
                    array.SetValue(arrayType, offset);

                    long currentAddress = baseAddress + offset;
                    for (int j = 0; j < arrSize.Value; j++)
                    {
                        var arrayItem = GetValue(arrayType, currentAddress);
                        if (arrayItem == null)
                        {

                        }
                        else
                        {
                            array[j] = arrayItem;
                            currentAddress += objSize;

                            string msg = string.Format("name= {0, -48} value= {1,-10}", field.Name, arrayItem);
                            Logger.WriteLine(msg);
                        }                        
                    }

                    
                    continue;
                }

                var value = GetValue(fieldType, baseAddress + offset);
                if (value != null)  // it's a simple datatype
                {
                    string msg = string.Format("name= {0, -48} value= {1,-10}", field.Name, value);
                    Logger.WriteLine(msg);
                    continue;
                }

                // it's a complex datatype, likely has it's own fields.
                // The code below was used to prevent stack overflow from recursion.
                *//*MemoryData data = new MemoryData()
                {
                    address = baseAddress + offset,
                    field = field,
                };
                leftover.Add(data); *//*



                PrintFields(fieldType, baseAddress + offset); // it must be a class. Search it for fields.
            }
        }*/

        public object GetValue(Type dataType, long address)
        {
            var primitiveValue = GetPrimitiveValue(dataType, address);
            if (primitiveValue != null)
                return primitiveValue;

            return GetComplexValue(dataType, address);
        }

        private object GetPrimitiveValue(Type dataType, long address)
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
            if (dataType == typeof(char))
                return *(char*)address;
            if (dataType == typeof(string) || dataType == typeof(char*) || dataType.Name.Contains("NMSString"))
                return Strings.ToString(address);
            return null; // it must be a complex type (class/enum/collection)
        }

        private object GetComplexValue(Type dataType, long address)
        {
            /*if (dataType.IsArray)
            {
                Logger.WriteLine("zzzzzzzzzz ARRAYT zzzzzzzzzzzzzzzzzzzzz");
                var arrayType = dataType.GetElementType();
                var objSize = NMSTemplate.SizeOf(arrayType);

                int? arrSize = dataType.GetCustomAttribute<NMSAttribute>()?.Size;
                //var arrayEnumType = dataType.GetCustomAttribute<NMSAttribute>()?.EnumType;
                if (arrSize == null)
                {
                    Logger.WriteLine("Array size is null");
                    return null;
                }

                object[] results = new object[arrSize.Value];

                long currentAddress = address;
                for (int i = 0; i < arrSize.Value; i++)
                {
                    var arrayItem = GetValue(arrayType, currentAddress);
                    results[i] = arrayItem;
                    currentAddress += objSize;
                }

                Logger.WriteLine("66666666666666 DONE 9999999999999");
                return results;
            }*/


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
            if (dataType.Name == "Vector4f")
            {
                var x = *(float*)address;
                var y = *(float*)(address + 0x4);
                var z = *(float*)(address + 0x8);
                var t = *(float*)(address + 0x12);
                return new libMBIN.NMS.Vector4f(x, y, z, t);
            }
            if (dataType.IsEnum)
            {
                int id = *(int*)(address);
                return Enum.GetValues(dataType).GetValue(id);
                /*var enumName = Strings.ToString(*(char*)address);
                if (!string.IsNullOrEmpty(enumName))
                {
                    bool success = Enum.TryParse(dataType, enumName, out var value);
                    return success ? value : null;
                }
                else
                {
                    int id = *(int*)(address);
                    return Enum.GetValues(dataType).GetValue(id);
                }*/
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