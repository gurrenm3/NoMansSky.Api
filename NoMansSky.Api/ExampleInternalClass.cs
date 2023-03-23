using Reloaded.Hooks.Definitions;
using Reloaded.ModHelper;
using System;
using System.Runtime.CompilerServices;

namespace NoMansSky.Api
{
    /// <summary>
    /// Represents the No Man's Sky class "ExampleInternalClass"
    /// </summary>
    public unsafe struct ExampleInternalClass
    {
        /// <summary>
        /// Represents the game function "ExampleInternalClass::AwardUnits(long self, int amountToAdd);"
        /// </summary>
        [FunctionAddress("48 89 5C 24 08 48 89 6C 24 10 48 89 74 24 18 57 48 83 EC 40 44 8B 81 BC")]
        public delegate long Award_Units(long self, int amountToAdd);

        /// <summary>
        /// Represents the game function "ExampleInternalClass::AwardNanites(long self, int amountToAdd);"
        /// </summary>
        [FunctionAddress("48 89 5C 24 08 48 89 6C 24 10 48 89 74 24 18 57 48 83 EC 40 44 8B 81 C0")]
        public delegate long Award_Nanites(long self, int amountToAdd);


        /// <summary>
        /// Calles the No Man's Sky function: ExampleInternalClass::AwardUnits.
        /// <br/>Requires a pointer to the object that will call the function, i.e.  self.
        /// </summary>
        public long AwardUnits(long self, int amountToAdd)
        {
            HookDefinitions.TryCreateAwardUnitsFunc();
            return HookDefinitions.awardUnitsFuncDef.GetWrapper()(self, amountToAdd);
        }


        /// <summary>
        /// Calles the No Man's Sky function: ExampleInternalClass::AwardUnits.
        /// <br/>Attempts to use this instance of the struct as the object that will call the function, i.e.  self.
        /// </summary>
        public long AwardUnits(int amountToAdd)
        {
            HookDefinitions.TryCreateAwardUnitsFunc();

            var self = (long)Unsafe.AsPointer(ref this);
            return HookDefinitions.awardUnitsFuncDef.GetWrapper()(self, amountToAdd);
        }

        /// <summary>
        /// Calles the No Man's Sky function: ExampleInternalClass::AwardNanites.
        /// <br/>Requires a pointer to the object that will call the function, i.e.  self.
        /// </summary>
        public long AwardNanites(long self, int amountToAdd)
        {
            HookDefinitions.TryCreateAwardUnitsFunc();
            return HookDefinitions.awardUnitsFuncDef.GetWrapper()(self, amountToAdd);
        }


        /// <summary>
        /// Calles the No Man's Sky function: ExampleInternalClass::AwardNanites.
        /// <br/>Attempts to use this instance of the struct as the object that will call the function, i.e.  self.
        /// </summary>
        public long AwardNanites(int amountToAdd)
        {
            HookDefinitions.TryCreateAwardUnitsFunc();

            var self = (long)Unsafe.AsPointer(ref this);
            return HookDefinitions.awardUnitsFuncDef.GetWrapper()(self, amountToAdd);
        }

        /// <summary>
        /// Create a hook for the provided function or get an existing one.
        /// <br/>Allows you to take control of the game's function and run your code before or after it does.
        /// </summary>
        public static IModEventHook<object[]?> GetOrCreateHook<T>() where T : Delegate
        {
            if (typeof(T) == typeof(Award_Units))
            {
                // setup award units hook
                HookDefinitions.TryCreateAwardUnitsHook();
                return HookDefinitions.awardUnitsEventHook;
            }
            else if (typeof(T) == typeof(Award_Nanites))
            {
                // setup award units hook
                return HookDefinitions.awardNanitesEventHook;
            }
            else
            {
                throw new ArgumentException($"");
                return null!;
            }
        }

        /// <summary>
        /// Contains all of the logic for defining and controlling hooks.
        /// <br/>Recommended for advanced users.
        /// </summary>
        public static class HookDefinitions
        {
            /// <summary>
            /// The function definition of Award_Units.
            /// </summary>
            public static IFunction<Award_Units> awardUnitsFuncDef = null!;

            /// <summary>
            /// The actual hook for Award_Units.
            /// </summary>
            public static IHook<Award_Units> awardUnitsHookDef = null!;

            /// <summary>
            /// The user friendly hook. Recommended that you only use this
            /// </summary>
            public static IModEventHook<object[]?> awardUnitsEventHook = null!;
            internal static void TryCreateAwardUnitsFunc()
            {
                if (awardUnitsFuncDef != null)
                    return;


                // create func
            }

            internal static void TryCreateAwardUnitsHook()
            {
                if (awardUnitsHookDef != null)
                    return;

                if (awardUnitsFuncDef == null)
                    TryCreateAwardUnitsFunc();

                awardUnitsEventHook = new SharedModEventHook<object[]?>();
                awardUnitsHookDef = awardUnitsFuncDef.Hook((a, b) =>
                {
                    var args = new object[] { a, b };
                    awardUnitsEventHook.Before.Run(args);
                    var result = awardUnitsHookDef.OriginalFunction.Invoke((long)args[0], (int)args[1]);

                    args = new object[] { args[0], args[1], result };
                    awardUnitsEventHook.After.Run(args);
                    return (int)args[2];
                });
            }



            public static IFunction<Award_Nanites> awardNanitesFuncDef = null!;
            public static IHook<Award_Nanites> awardNanitesHookDef = null!;
            public static IModEventHook<object[]?> awardNanitesEventHook = null!;
            internal static void TryCreateAwardNanitesFunc()
            {
                if (awardNanitesFuncDef != null)
                    return;

                // create func
            }

        }


    }
}


public class HookDefinitionsBuilder
{

}