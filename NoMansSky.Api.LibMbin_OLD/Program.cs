using libMBIN;
using libMBIN.NMS;
using Reloaded.ModHelper;
using System.Reflection;
using System.Text;



var types = typeof(NMSTemplate).Assembly.GetTypes().Where(t => t.IsAssignableTo(typeof(NMSTemplate)));

foreach (var type in types)
{
    //string saveDir = @"D:\Repos\C#\NoMansSky.Api\NoMansSky.Api.LibMbin\GameClasses\";
    string saveDir = @"../../../Game Classes/";

    if (!string.IsNullOrEmpty(type.Namespace))
        saveDir += type.Namespace.Replace("libMBIN", "").Trim('.');
    Directory.CreateDirectory(saveDir);

    Console.WriteLine($"Generating class for {type.FullName}");
    string text = GenerateClassText(type);

    File.WriteAllText($"{saveDir}\\{type.Name}.cs", text);
}

Console.WriteLine($"All classes written to file.");



string GenerateClassText(Type type)
{
    StringBuilder sb = new StringBuilder();

    // add usings here.
    var usings = GetUsingStatements(type);
    foreach (var item in usings)
    {
        sb.AppendLine($"using {item};");
    }

    if (usings.Any())
        sb.AppendLine();

    // add namespace here.
    sb.AppendLine($"namespace NoMansSky.Api.LibMbin;");
    sb.AppendLine();

    // add class declaration here.
    //sb.AppendLine($"public unsafe class {type.Name} : MbinClass<{type.FullName}>");

    string baseClass = type != typeof(NMSTemplate) ? "NMSTemplate" : "MbinClass";
    sb.AppendLine($"public unsafe class {type.Name} : {baseClass}");
    sb.AppendLine("{");


    // add properties here.
    var fields = type.GetFields();
    foreach (var field in fields)
    {
        string prop = GenerateProperty(type, field);
        if (!string.IsNullOrEmpty(prop))
        {
            sb.Append(prop);
            sb.AppendLine();
        }
    }


    // add ctor here.
    sb.AppendLine($"\tpublic {type.Name}(long address) : base(address)");
    sb.AppendLine("\t{");
    sb.AppendLine();
    sb.AppendLine("\t}");

    sb.AppendLine("}");


    // add any discovered methods.
    // TODO

    return sb.ToString();
}

string GenerateProperty(Type parentType, FieldInfo field)
{
    int offset = NMSTemplate.OffsetOf(parentType, field.Name);
    if (StringUtils.IsString(field.FieldType))
    {
        return CreateStringProperty(field, offset);
    }
    else if (EnumUtils.IsEnum(field.FieldType))
    {

        return CreateEnumProperty(field, offset);
    }
    else if (field.FieldType.IsClass)
    {
        return CreateClassProperty(field, offset);
    }
    else if (PrimitiveUtils.IsPrimitive(field.FieldType))
    {
        return CreatePrimitiveProperty(field, offset);
    }

    return "";
}

string CreatePrimitiveProperty(FieldInfo field, int offset)
{
    StringBuilder sb = new StringBuilder();

    string fieldType = field.FieldType.Name;
    sb.AppendLine($"\tpublic {fieldType} {field.Name}");
    sb.AppendLine("\t{");
    sb.AppendLine($"\t\tget => GetValue<{fieldType}>();");
    sb.AppendLine($"\t\tset => TrySetValue<{fieldType}>(value);");

    /*sb.AppendLine("\t\tset {");
    sb.AppendLine($"\t\t\tif (value != {field.Name})");
    sb.AppendLine($"\t\t\t\tChangePropertyValue(value, newValue => *({fieldType}*)(address + GetOffset()) = ({fieldType})newValue);");
    sb.AppendLine("\t\t}");*/
    sb.AppendLine("\t}");
    return sb.ToString();
}

string CreateStringProperty(FieldInfo field, int offset)
{
    StringBuilder sb = new StringBuilder();

    string fieldType = field.FieldType.Name;
    sb.AppendLine($"\tpublic string {field.Name}");
    sb.AppendLine("\t{");
    sb.AppendLine($"\t\tget => GetValue<{fieldType}>();");
    sb.AppendLine($"\t\tset => TrySetValue<{fieldType}>(value);");

    /*sb.AppendLine("\t\tset {");
    sb.AppendLine($"\t\t\tif (value != {field.Name})");
    sb.AppendLine($"\t\t\t\tChangePropertyValue(value, newValue => StringUtils.SetValue(address  + GetOffset(), newValue));");
    sb.AppendLine("\t\t}");*/
    sb.AppendLine("\t}");
    return sb.ToString();
}

string CreateEnumProperty(FieldInfo field, int offset)
{
    StringBuilder sb = new StringBuilder();

    string fieldType = field.FieldType.Name;
    sb.AppendLine($"\tpublic {field.FieldType.FullName.Replace("+",".")} {field.Name}");
    sb.AppendLine("\t{");
    sb.AppendLine($"\t\tget => GetValue<{field.FieldType.FullName.Replace("+", ".")}>();");
    sb.AppendLine($"\t\tset => TrySetValue<{field.FieldType.FullName.Replace("+", ".")}>(value);");

    /*sb.AppendLine("\t\tset {");
    sb.AppendLine($"\t\t\tif (value != {field.Name})");
    sb.AppendLine($"\t\t\t\tChangePropertyValue(value, newValue => EnumUtils.SetValue(address + GetOffset(), newValue));");
    sb.AppendLine("\t\t}");*/
    sb.AppendLine("\t}");
    return sb.ToString();
}

string CreateClassProperty(FieldInfo field, int offset)
{
    var sb = new StringBuilder();

    bool isList = false;
    bool isArray = false;
    int arraySize = 1;
    string fieldType = field.FieldType.Name;

    if (fieldType.Contains("List`1"))
    {
        isList = true;
        //fieldType = fieldType.Replace("`1", $"<{field.FieldType.GenericTypeArguments[0].Name}>");
        fieldType = field.FieldType.GenericTypeArguments[0].Name;
    }
    else if (field.FieldType.IsArray)
    {
        isArray = true;
        fieldType = fieldType.Replace($"[]", "");

        var attr = field.GetCustomAttribute<NMSAttribute>();
        if (attr != null)
            arraySize = attr.Size;
    }


    if (isArray)
        sb.AppendLine($"\tpublic VirtualArray<{fieldType}> {field.Name}");
    else if (isList)
        sb.AppendLine($"\tpublic VirtualList<{fieldType}> {field.Name}");
    else
        sb.AppendLine($"\tpublic {fieldType} {field.Name}");
    


    sb.AppendLine("\t{");

    if (isList)
        sb.AppendLine($"\t\tget => cache.GetOrAddValue(new VirtualList<{fieldType}>(address + GetOffset()));");
    else if (isArray)
        sb.AppendLine($"\t\tget => cache.GetOrAddValue(new VirtualArray<{fieldType}>(address + GetOffset(), {arraySize}));");
    else
        sb.AppendLine($"\t\tget => GetValue<{fieldType}>();");


    /*if (isList)
        sb.AppendLine($"\t\tget => listConverter.GetValue<{fieldType}>(address + GetOffset());");
    else if (isArray)
        sb.AppendLine($"\t\tget => arrayConverter.GetValue<{fieldType}>(address + GetOffset(), {arraySize});");
    else
        sb.AppendLine($"\t\tget => cache.GetOrAddValue(new {fieldType}(address + GetOffset()));");*/
    

    sb.AppendLine($"\t\tset => TrySetValue<{fieldType}>(value);");

    /*sb.AppendLine("\t\tset");
    sb.AppendLine("\t\t{");
    sb.AppendLine($"\t\t\tif (value == {field.Name}) return;");
    sb.AppendLine("");
    sb.AppendLine("\t\t\tChangePropertyValue(value, newValue => ");
    sb.AppendLine("\t\t\t{");
    sb.AppendLine("\t\t\t\tcache.AddOrUpdateValue(newValue);");
    sb.AppendLine($"\t\t\t\tmemoryMgr.SetValue(address + GetOffset(), newValue);");
    sb.AppendLine("\t\t\t});");
    sb.AppendLine("\t\t}");*/

    sb.AppendLine("\t}");
    return sb.ToString();
}

List<string> GetUsingStatements(Type type)
{
    List<string> usings = new List<string>
    {
        "Reloaded.ModHelper",
        "System"
    };

    foreach (var field in type.GetFields())
    {
        if (!usings.Contains(field.FieldType.Namespace))
            usings.Add(field.FieldType.Namespace);
    }

    return usings;
}