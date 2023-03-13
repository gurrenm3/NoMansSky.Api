using libMBIN.NMS.GameComponents;
using Microsoft.CodeAnalysis;
using PlayerStateGenerator.ConsoleApp;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

Console.WriteLine();


LibMbinStateData libmbinStateData = new LibMbinStateData();

var variables = await libmbinStateData.GetClassVariables();


string classText = File.ReadAllText("CopyPlayerStateDataFunc.txt");


List<ClassVariable> foundVariables = new List<ClassVariable>();

bool any = true;

while (any)
{
    any = false;
    StringBuilder sb = new StringBuilder();
    var lines = classText.Split('\n');

    for (int i = 0; i < lines.Length; i++)
    {
        var line = lines[i];
        var variable = variables.FirstOrDefault(v => line.Contains($" + {v.Offset}"));
        if (variable == null)
        {
            sb.Append(line);
            continue;
        }

        if (!foundVariables.Any(v => v.Offset == variable.Offset))
        {
            if (line.Contains(" = "))
            {
                Console.WriteLine(line);
                foundVariables.Add(variable);
            }
        }

        any = true;

        var lineSplit = line.Split($" + {variable.Offset}");

        var idaVaribaleName = GetVariableNameFromText(lineSplit[0]);
        var cleanedLine = line.Replace($"{idaVaribaleName} + {variable.Offset}", $"PlayerStateData::{variable.Name}");
        sb.Append(cleanedLine);
    }

    classText = sb.ToString();
}


//File.WriteAllText("Cleaned Function Text.txt", classText);



foundVariables = foundVariables.OrderBy(i => i.Offset).ToList();

foreach (var variable in foundVariables)
{
    string foundVariable = $"{variable.Offset}  {variable.VariableType.FullName}  {variable.Name}";
    //Console.WriteLine(variable.Name);


}



string GetVariableNameFromText(string text)
{
    StringBuilder sb = new StringBuilder();

    for (int i = text.Length - 1; i >= 0; i--)
    {
        var letter = text[i];
        if (!isAlphaNumeric(letter.ToString()) || letter == ' ')
            break;

        sb.Insert(0, letter);
    }

    return sb.ToString();
}


bool isAlphaNumeric(string strToCheck)
{
    Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
    return rg.IsMatch(strToCheck);
}