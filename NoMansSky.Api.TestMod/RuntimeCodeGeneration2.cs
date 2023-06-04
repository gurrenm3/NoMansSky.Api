using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Reloaded.Hooks.Definitions;
using Reloaded.ModHelper;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

class RuntimeCodeGenerator2
{
    public static void GenerateCode()
    {
        string code = @"
using System;
using System.Reflection;
using Reloaded.ModHelper;
using Reloaded.Hooks.Definitions;
using NoMansSky.Api;

public unsafe class MyClass 
{
    public delegate uint AwardUnitsFunc(long self, int change);

    public static IFunction<AwardUnitsFunc> awardUnitsFuncDef;
	public static IHook<AwardUnitsFunc> awardUnitsHookDef;
	public static IModEventHook<object[]?> awardUnitsEventHook;

    public static void MyMethod()
    {
        Console.WriteLine(""Running dynamic hook..."");
        AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
        
        if (awardUnitsFuncDef != null)
				return;

		var functionPtr = HookRegister.GetAddressFromDelegate<AwardUnitsFunc>(isXrefSig: false);
		bool isBadPtr = Kernel32.IsBadReadPtr((nint)functionPtr, 7);
		if (isBadPtr)
		{
			ConsoleUtils.WriteError(""Failed to located the function \""AwardUnitsFunc\"" in the game! To prevent the game from crashing it will be unusable."");
			return;
		}
		awardUnitsFuncDef = HookRegister.hooksInstance.CreateFunction<AwardUnitsFunc>(functionPtr);
        Console.WriteLine(""Finished running dynamic hook..."");
    }

        private static Assembly? CurrentDomain_AssemblyResolve(object? sender, ResolveEventArgs args)
        {
            Console.WriteLine(args.Name);
            return typeof(IHook).Assembly;
        }
}";

        

        SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(code);

        string assemblyName = Path.GetRandomFileName();

        var compilation = CSharpCompilation.Create(
            assemblyName,
            new[] { syntaxTree },
            GetReferences(),
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, allowUnsafe: true));

        using (var ms = new MemoryStream())
        {
            var result = compilation.Emit(ms);

            if (!result.Success)
            {
                foreach (var diagnostic in result.Diagnostics)
                {
                    Console.WriteLine($"{diagnostic.Id}: {diagnostic.GetMessage()}");
                }
            }
            else
            {
                ms.Seek(0, SeekOrigin.Begin);
                var assembly = Assembly.Load(ms.ToArray());

                var type = assembly.GetType("MyClass");
                var method = type.GetMethod("MyMethod");

                //var methodResult = method.Invoke(null, new object[] { 10, 20 });
                var methodResult = method.Invoke(null, null);

                Console.WriteLine(methodResult);
            }
        }
    }

    private static MetadataReference[] GetReferences()
    {
        var references = AppDomain.CurrentDomain
            .GetAssemblies()
            .Where(a => !a.IsDynamic && !string.IsNullOrWhiteSpace(a.Location))
            .Select(a => MetadataReference.CreateFromFile(a.Location))
            .ToList();

        references.Add(MetadataReference.CreateFromFile(typeof(Console).Assembly.Location));
        references.Add(MetadataReference.CreateFromFile(typeof(object).Assembly.Location));
        references.Add(MetadataReference.CreateFromFile("C:\\Users\\thoma\\Desktop\\Reloaded-II\\Mods\\NoMansSky.Api\\Reloaded.Hooks.Definitions.dll"));

        List<PortableExecutableReference> refsToRemove = new();
        for (int i = 0; i < references.Count; i++)
        {
            var reference = references[i];
            //Console.WriteLine(reference.Display);
            //continue;

            /*if (references.Count(r => r.Display == reference.Display && !refsToRemove.Any(re => re.Display == reference.Display)) > 1)
                refsToRemove.Add(reference);*/

            var fileInfo = new FileInfo(reference.FilePath);
            //if (references.Count(r => new FileInfo(r.FilePath).Name == fileInfo.Name && !refsToRemove.Any(re => new FileInfo(re.FilePath).Name == fileInfo.Name)) > 1)
            /*if (references.Count(r => new FileInfo(r.FilePath).Name == fileInfo.Name && !refsToRemove.Any(re => new FileInfo(re.FilePath).Name == fileInfo.Name)) > 1)
                refsToRemove.Add(reference);*/


            
        }


        var matches = references.FindAll(r => r.FilePath.EndsWith("Reloaded.Memory.dll"));
        ConsoleUtils.WriteLine($"Count: {matches.Count}");

        foreach (var item in matches)
        {
            ConsoleUtils.WriteLine("----------------");
            ConsoleUtils.WriteLine(item.FilePath);
            foreach (var a in item.Properties.Aliases)
            {
                ConsoleUtils.WriteLine(a);
            }
        }

        refsToRemove.Add(references.First(r => r.FilePath.Contains("Reloaded-II\\Loader\\x64\\Reloaded.Memory.dll")));
        refsToRemove.Add(references.First(r => r.FilePath.Contains("Mods\\reloaded.sharedlib.hooks\\x64\\Reloaded.Memory.dll")));
        refsToRemove.Add(references.First(r => r.FilePath.Contains("C:\\Users\\thoma\\Desktop\\Reloaded-II\\Mods\\reloaded.sharedlib.hooks\\x64\\Reloaded.Hooks.Definitions.dll")));

        refsToRemove.ForEach(r => references.Remove(r));
        return references.ToArray();
    }
}
