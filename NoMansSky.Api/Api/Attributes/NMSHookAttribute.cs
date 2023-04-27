using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;

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
public class NMSHookAttribute<T> : ModMethodAttribute, INMSHook where T : Delegate
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public RunHook HookTime { get; protected set; }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public IModEventHook<object[]?> EventHook { get; set; }
    
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public bool IsSuccessfullyLoaded { get; set; }

    const string RESULT_KEY = "__result";
    List<HookParameter> hookParams;
    object[] passedArgsValues;


    public NMSHookAttribute(RunHook hookType = RunHook.After)
    {
        this.HookTime = hookType;
    }    

    /// <summary>
    /// Called when the attribute is loaded. Does the actual hooking and wires everything up.
    /// </summary>
    public override void OnAttributeLoaded()
    {

        hookParams = GetHookParameters();
        if (hookParams == null)
        {
            ConsoleUtils.WriteLine("hook params are null");
            return;
        }

        EventHook = GetOrAddHook();

        if (EventHook == null)
        {
            ConsoleUtils.WriteLine("Event hook is null");
            return;
        }
        
        IsSuccessfullyLoaded = true;
        passedArgsValues = new object[hookParams.Count];

        // if the user's function has no args then exectute it as fast as possible.
        var modEvent = HookTime == RunHook.Before ? EventHook.Before : EventHook.After;
        if (hookParams.Count == 0)
        {
            modEvent.AddRunner(args => Info.TargetMethod.Invoke(ClassInstance));
            return;
        }

        modEvent.AddRunner(args =>
        {
            for (int i = 0; i < hookParams.Count; i++)
            {
                passedArgsValues[i] = args[hookParams[i].RealArgument.Position];
            }

            Info.TargetMethod.Invoke(ClassInstance, passedArgsValues);

            for (int i = 0; i < hookParams.Count; i++)
            {
                var hookParam = hookParams[i];
                args[hookParam.RealArgument.Position] = passedArgsValues[i];
            }
        });
    }

    /// <summary>
    /// Creates or returns the ModEventHook that is attached to this game function.
    /// </summary>
    /// <returns></returns>
    private IModEventHook<object[]?> GetOrAddHook()
    {
        var indexOfName = typeof(T).FullName.LastIndexOf('+');
        var parentClassName = typeof(T).FullName.Remove(indexOfName);
        var parentClassType = typeof(T).Assembly.GetType(parentClassName);

        // actually hook it.
        var hookFunction = parentClassType.GetMethods().FirstOrDefault(m => m.Name.Contains("GetOrAddHook")).MakeGenericMethod(typeof(T));
        hookFunction.Invoke(null);

        string delegateName = typeof(T).Name;
        if (delegateName.EndsWith("Func"))
            delegateName = delegateName.Remove(delegateName.Length - 4);

        //var modEventHook = typeof(T).Assembly.GetType($"{parentClassName}+HookDefinitions")?.GetField($"{delegateName}EventHook")?.GetValue(null);
        var modEventHook = typeof(T).Assembly.GetType($"{parentClassName}+HookDefinitions")?.GetFields().FirstOrDefault(f => f.Name.ToLower() == $"{delegateName}EventHook".ToLower())?.GetValue(null);
        return modEventHook as IModEventHook<object[]?> ?? null;
    }

    /// <summary>
    /// Returns a list of the parameters that the hook is asking for.
    /// </summary>
    /// <returns></returns>
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

            // if we get an error then skip this hook.
            if (ShowArgumentError(arg))
                return null;

            results.Add(arg);
        }
        return results;
    }

    /// <summary>
    /// Check the argument to make suer it is valid and matches the game function.
    /// </summary>
    /// <param name="arg"></param>
    /// <returns>True if there is an error, otherwise false.</returns>
    private bool ShowArgumentError(HookParameter arg)
    {
        if (arg.RealArgument == null)
        {
            string message = $"{Info.TargetMethod.Name} requested an argument named \"{arg.ParamName}\" from the game function \"{typeof(T).Name}\" but it doesn't" +
                $" have an argument with that name.";

            if (arg.ParamName.ToLower() == "result")
            {
                message += " If you are trying to get the result of the function use \"__result\" with two underscores instead.";
                if (HookTime == RunHook.Before)
                    message += " Also, you can't use it in a \"Before\" hook, it must be in an \"After\" hook in order to get the result of the function AFTER it ran.";
            }

            ConsoleUtils.WriteError($"{message} This hook will be skipped.");
            return true;
        }

        // check if they are different types but make sure it's just just a reference of the other. Ends with "&" sign if it is.
        else if ((arg.RealArgument.ParamType != arg.ParamType && $"{arg.RealArgument.ParamType.Name}&" != arg.ParamType.Name) && (arg.RealArgument.ParamType.IsPointer && arg.ParamType != typeof(long)))
        {
            ConsoleUtils.WriteError($"The hook for {typeof(T).Name} used the wrong type for {arg.ParamName}." +
                $" Expected: \"{arg.RealArgument.ParamType.FullName}\"  but got  \"{arg.ParamType.FullName}\". This hook will be skipped.");
            return true;
        }

        else if (arg.ParamType.IsPointer)
        {
            ConsoleUtils.WriteError($"Due to the nature of C#, you can't use a Instance as one of your arguments." +
                $" Instead set the type to \"long\" and then cast it to a pointer within your hook. This hook will be skipped.");
            return true;
        }
        else if (arg.ParamName == RESULT_KEY && HookTime == RunHook.Before)
        {
            ConsoleUtils.WriteError($"Tried using \"{RESULT_KEY}\" inside of a \"Before\" hook. \"{RESULT_KEY}\" only works in an \"After\" hook.");
            return true;
        }

        return false;
    }

    /// <summary>
    /// Returns a list of the actual parameters in the game function.
    /// </summary>
    /// <returns></returns>
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


    /// <summary>
    /// Represents basic info about a parameter within a function or delegate.
    /// </summary>
    class ParamInfo
    {
        public string ParamName { get; set; }
        public Type ParamType { get; set; }
        public int Position { get; set; }
    }

    /// <summary>
    /// Represents basic info about a parameter within the user's hook.
    /// </summary>
    class HookParameter : ParamInfo
    {
        /// <summary>
        /// Represents the real argument within the actual delegate.
        /// </summary>
        public ParamInfo RealArgument { get; set; }
    }
}