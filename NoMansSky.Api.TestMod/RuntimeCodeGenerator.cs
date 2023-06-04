namespace NoMansSky.Api.TestMod;

using Reloaded.Hooks.Definitions;
using Reloaded.ModHelper;
using System;
using System.Reflection;
using System.Reflection.Emit;
using static NoMansSky.Api.Definitions.cGcPlayerState;

public static class RuntimeCodeGenerator
{
    public static void GenerateCode()
    {
        TypeBuilder typeBuilder = CreateTypeBuilder();

        CreateField(typeBuilder, "awardUnitsFuncDef", typeof(IFunction<>).MakeGenericType(typeof(AwardUnitsFunc)));
        CreateField(typeBuilder, "awardUnitsHookDef", typeof(IHook<>).MakeGenericType(typeof(AwardUnitsFunc)));
        CreateField(typeBuilder, "awardUnitsEventHook", typeof(IModEventHook<>).MakeGenericType(typeof(object[])));

        CreateMethod(typeBuilder, "TryCreateAwardUnitsFunc");

        Type generatedType = typeBuilder.CreateType();

        MethodInfo methodInfo = generatedType.GetMethod("TryCreateAwardUnitsFunc");
        object instance = Activator.CreateInstance(generatedType);
        methodInfo.Invoke(instance, null);
    }

    private static TypeBuilder CreateTypeBuilder()
    {
        AssemblyName assemblyName = new AssemblyName("GeneratedAssembly");
        AssemblyBuilder assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
        ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("GeneratedModule");
        TypeBuilder typeBuilder = moduleBuilder.DefineType("GeneratedType", TypeAttributes.Public);
        return typeBuilder;
    }

    private static void CreateField(TypeBuilder typeBuilder, string fieldName, Type fieldType)
    {
        FieldBuilder fieldBuilder = typeBuilder.DefineField(fieldName, fieldType, FieldAttributes.Public | FieldAttributes.Static);
        fieldBuilder.SetConstant(null);
    }

    private static void CreateMethod(TypeBuilder typeBuilder, string methodName)
    {
        MethodBuilder methodBuilder = typeBuilder.DefineMethod(methodName,
            MethodAttributes.Private | MethodAttributes.Static,
            typeof(void),
            Type.EmptyTypes);

        ILGenerator ilGenerator = methodBuilder.GetILGenerator();
        ilGenerator.Emit(OpCodes.Ldsfld, typeBuilder.GetField("awardUnitsFuncDef"));
        ilGenerator.Emit(OpCodes.Brtrue_S, ilGenerator.DefineLabel());
        ilGenerator.Emit(OpCodes.Call, typeof(HookRegister).GetMethod("GetAddressFromDelegate").MakeGenericMethod(typeof(AwardUnitsFunc)));
        ilGenerator.Emit(OpCodes.Ldc_I4_0);
        ilGenerator.Emit(OpCodes.Call, typeof(Kernel32).GetMethod("IsBadReadPtr"));
        ilGenerator.Emit(OpCodes.Brfalse_S, ilGenerator.DefineLabel());
        ilGenerator.Emit(OpCodes.Ldstr, "Failed to locate the function \"AwardUnitsFunc\" in the game! To prevent the game from crashing it will be unusable.");
        ilGenerator.Emit(OpCodes.Call, typeof(ConsoleUtils).GetMethod("WriteError"));
        ilGenerator.Emit(OpCodes.Ret);
    }
}
