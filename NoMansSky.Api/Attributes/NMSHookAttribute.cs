using NoMansSky.Api.libMBIN;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NoMansSky.Api;

/// <summary>
/// Defines when a hook should run in relation to the hooked function.
/// </summary>
public enum RunHook
{
    /// <summary>
    /// Hook should run BEFORE the original function.
    /// </summary>
    Before,

    /// <summary>
    /// Hook should run AFTER the original function.
    /// </summary>
    After
}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class NMSHookAttribute<T> : ModMethodAttribute where T : Delegate
{
    class ParamInfo
    {
        public string ParamName { get; set; }
        public Type ParamType { get; set; }
        public int Position { get; set; }
    }

    class HookParameter : ParamInfo
    {
        /// <summary>
        /// Represents the real argument within the actual delegate.
        /// </summary>
        public ParamInfo RealArgument { get; set; }
    }

    public RunHook HookTime { get; protected set; }
    public IModEventHook<object[]?> EventHook { get; private set; }

    const string RESULT_KEY = "__result";
    List<HookParameter> hookParams;
    object[] passedArgsValues;

    public NMSHookAttribute(RunHook hookType = RunHook.After)
    {
        this.HookTime = hookType;
    }

    

    public override void OnAttributeLoaded()
    {
        hookParams = GetHookParameters();
        EventHook = GetOrAddHook();
        passedArgsValues = new object[hookParams.Count];

        // if the user's function has no args then exectute it as fast as possible.
        var modEvent = HookTime == RunHook.Before ? EventHook.Before : EventHook.After;
        if (hookParams.Count == 0)
        {
            modEvent.AddRunner(args => Info.TargetMethod.Invoke());
            return;
        }


        if (HookTime == RunHook.Before)
        {
            EventHook.Before.AddRunner(args =>
            {
                ConsoleUtils.Log("Hello from EventHook.Before.AddRunner");

                for (int i = 0; i < hookParams.Count; i++)
                {
                    passedArgsValues[i] = args[hookParams[i].RealArgument.Position];
                }

                Info.TargetMethod.Invoke(null, passedArgsValues);

                for (int i = 0; i < hookParams.Count; i++)
                {
                    var hookParam = hookParams[i];
                    args[hookParam.RealArgument.Position] = passedArgsValues[i];
                }
            });
        }
        else
        {
            EventHook.After.AddRunner(args =>
            {
                ConsoleUtils.Log("Hello from EventHook.After.AddRunner");
                int length = args.Length;

                for (int i = 0; i < hookParams.Count; i++)
                {
                    passedArgsValues[i] = args[hookParams[i].RealArgument.Position];
                }

                Info.TargetMethod.Invoke(null, passedArgsValues);

                return;
                for (int i = 0; i < hookParams.Count; i++)
                {
                    var hookParam = hookParams[i];
                    args[hookParam.RealArgument.Position] = passedArgsValues[i];
                }
            });
        }
    }

    private IModEventHook<object[]?> GetOrAddHook()
    {
        var indexOfName = typeof(T).FullName.IndexOf('+');
        var parentClassName = typeof(T).FullName.Remove(indexOfName);
        var parentClassType = typeof(T).Assembly.GetType(parentClassName);

        // actually hook it.
        var hookFunction = parentClassType.GetMethods().FirstOrDefault(m => m.Name.Contains("GetOrAddHook")).MakeGenericMethod(typeof(T));
        hookFunction.Invoke(null);

        var modEventHook = typeof(T).Assembly.GetType($"{parentClassName}+HookDefinitions")?.GetField($"{typeof(T).Name}EventHook")?.GetValue(null);
        return modEventHook as IModEventHook<object[]?> ?? null;
    }

    private List<HookParameter> GetHookParameters()
    {
        List<HookParameter> results = new();
        var delegateArgs = GetDelegateArgs();
        var hookArgs = Info.TargetMethod.GetParameters();
        for (int i = 0; i < hookArgs.Length; i++)
        {
            HookParameter arg = new()
            {
                ParamName = hookArgs[i].Name,
                ParamType = hookArgs[i].ParameterType,
                Position = i,
            };
            arg.RealArgument = delegateArgs.FirstOrDefault(a => a.ParamName == arg.ParamName);

            if (arg.RealArgument == null)
            {
                ConsoleUtils.LogError($"The hook for {typeof(T).Name} tried using the argument {arg.ParamName} but" +
                    $" the real game function doesn't have one with that name! This argument will be skipped.");
                continue;
            }

            // check if they are different types but make sure it's just just a reference of the other. Ends with "&" sign if it is.
            else if ((arg.RealArgument.ParamType != arg.ParamType && $"{arg.RealArgument.ParamType.Name}&" != arg.ParamType.Name) && (arg.RealArgument.ParamType.IsPointer && arg.ParamType != typeof(long)))
            {
                ConsoleUtils.LogError($"The hook for {typeof(T).Name} used the wrong type for {arg.ParamName}." +
                    $" Expected: \"{arg.RealArgument.ParamType.FullName}\"  but got  \"{arg.ParamType.FullName}\". This argument will be skipped.");
                continue;
            }

            else if (arg.ParamType.IsPointer)
            {
                ConsoleUtils.LogError($"Due to the nature of C#, you can't use a Pointer as one of your arguments." +
                    $" Instead set the type to \"long\" and then cast it to a pointer within your hook. This argument will be skipped.");
                continue;
            }
            else if (arg.ParamName == RESULT_KEY && HookTime == RunHook.Before)
            {
                ConsoleUtils.LogError($"Tried using \"{RESULT_KEY}\" inside of a \"Before\" hook. \"{RESULT_KEY}\" only works in an \"After\" hook.");
                continue;
            }
            results.Add(arg);
        }
        return results;
    }

    private List<ParamInfo> GetDelegateArgs()
    {
        List<ParamInfo> args = new();

        var invoke = typeof(T).GetMethod("Invoke");
        var invokeArgs = invoke.GetParameters();
        for (int i = 0; i < invokeArgs.Length; i++)
        {
            args.Add(new()
            {
                Position = i,
                ParamType = invokeArgs[i].ParameterType,
                ParamName = invokeArgs[i].Name
            });
        }

        if (invoke.ReturnType != typeof(void))
        {
            var returnArg = new ParamInfo()
            {
                Position = args.Count, // add return as last one
                ParamType = invoke.ReturnType,
                ParamName = RESULT_KEY
            };
            args.Add(returnArg);
        }

        return args;
    }
}