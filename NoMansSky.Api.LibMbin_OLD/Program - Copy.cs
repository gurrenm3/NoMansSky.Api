/*using libMBIN;
using libMBIN.NMS;
using Reloaded.ModHelper;
using System.Reflection;
using System.Text;



var types = typeof(NMSTemplate).Assembly.GetTypes().Where(t => t.IsAssignableTo(typeof(NMSTemplate)));

foreach (var type in types)
{
    //string saveDir = @"D:\Repos\C#\NoMansSky.Api\NoMansSky.Api.LibMbin\GameClasses\";
    string saveDir = @"../../../GameClasses/";

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
    sb.AppendLine($"public unsafe class {type.Name} : NMSTemplate");
    sb.AppendLine("{");


    // add properties here.
    var fields = type.GetFields();
    foreach (var field in fields)
    {
        string prop = GenerateProperty(type, field);
        if (!string.IsNullOrEmpty(prop))
            sb.Append(prop);
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
    sb.AppendLine($"\t\tget => PrimitiveUtils.GetValue<{fieldType}>(address + {offset});");
    sb.AppendLine("\t\tset");
    sb.AppendLine("\t\t{");
    sb.AppendLine($"\t\t\tif (value == {field.Name})");
    sb.AppendLine("\t\t\t\treturn;");
    sb.AppendLine("");
    sb.AppendLine($"\t\t\tChangePropertyValue(value, newValue => PrimitiveUtils.SetValue(address + {offset}, newValue));");
    sb.AppendLine("\t\t}");
    sb.AppendLine("\t}");
    return sb.ToString();
}

string CreateStringProperty(FieldInfo field, int offset)
{
    StringBuilder sb = new StringBuilder();

    string fieldType = field.FieldType.Name;
    sb.AppendLine($"\tpublic string {field.Name}");
    sb.AppendLine("\t{");
    sb.AppendLine($"\t\tget => StringUtils.GetValue(address + {offset});");
    sb.AppendLine("\t\tset");
    sb.AppendLine("\t\t{");
    sb.AppendLine($"\t\t\tif (value == {field.Name})");
    sb.AppendLine("\t\t\t\treturn;");
    sb.AppendLine("");
    sb.AppendLine($"\t\t\tChangePropertyValue(value, newValue => StringUtils.SetValue(address + {offset}, newValue));");
    sb.AppendLine("\t\t}");
    sb.AppendLine("\t}");
    return sb.ToString();
}

string CreateEnumProperty(FieldInfo field, int offset)
{
    StringBuilder sb = new StringBuilder();

    string fieldType = field.FieldType.Name;
    sb.AppendLine($"\tpublic {field.FieldType.FullName.Replace("+",".")} {field.Name}");
    sb.AppendLine("\t{");
    sb.AppendLine($"\t\tget => EnumUtils.GetValue<{field.FieldType.FullName.Replace("+", ".")}> (address + {offset});");
    sb.AppendLine("\t\tset");
    sb.AppendLine("\t\t{");
    sb.AppendLine($"\t\t\tif (value == {field.Name})");
    sb.AppendLine("\t\t\t\treturn;");
    sb.AppendLine("");
    sb.AppendLine($"\t\t\tChangePropertyValue(value, newValue => EnumUtils.SetValue(address + {offset}, newValue));");
    sb.AppendLine("\t\t}");
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
        fieldType = fieldType.Replace("`1", $"<{field.FieldType.GenericTypeArguments[0].Name}>");
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
        sb.AppendLine($"\tpublic {fieldType}[] {field.Name}");
    else
        sb.AppendLine($"\tpublic {fieldType} {field.Name}");
    


    sb.AppendLine("\t{");
    
    if (isList)
        sb.AppendLine($"\t\tget => cache.GetOrAddValue(new {fieldType}());");
    else if (isArray)
        sb.AppendLine($"\t\tget => ({fieldType}[])Convert.ChangeType(arrayConverter.GetValue(address + {offset}, typeof({fieldType}[]), {arraySize}), typeof({fieldType}[]));");
    else if (offset != 0)
        sb.AppendLine($"\t\tget => cache.GetOrAddValue(new {fieldType}(address + {offset}));");
    else                                                         
        sb.AppendLine($"\t\tget => cache.GetOrAddValue(new {fieldType}(address));");

    sb.AppendLine("\t\tset");
    sb.AppendLine("\t\t{");
    sb.AppendLine($"\t\t\tif (value == {field.Name})");
    sb.AppendLine("\t\t\t\treturn;");
    sb.AppendLine("");
    sb.AppendLine("\t\t\tChangePropertyValue(value, newValue => ");
    sb.AppendLine("\t\t\t{");
    sb.AppendLine("\t\t\t\tcache.AddOrUpdateValue(newValue);");

    if (isList)
        sb.AppendLine($"\t\t\t\tlistConverter.SetValue(address + {offset}, newValue);");
    else if (isArray)
        sb.AppendLine($"\t\t\t\tarrayConverter.SetValue(address + {offset}, newValue);");
    else if (field.FieldType.IsAssignableTo(typeof(INMSString)))
        sb.AppendLine($"\t\t\t\tnmsStringConverter.SetValue(address + {offset}, newValue);");
    else
        sb.AppendLine($"\t\t\t\tclassConverter.SetValue(address + {offset}, newValue);");

    sb.AppendLine("\t\t\t});");

    sb.AppendLine("\t\t}");
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
}*/