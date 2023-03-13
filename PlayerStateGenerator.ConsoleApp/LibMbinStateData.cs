using libMBIN.NMS.GameComponents;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerStateGenerator.ConsoleApp
{
    internal class LibMbinStateData
    {
        public LibMbinStateData()
        {

        }

        public async Task<List<ClassVariable>> GetClassVariables()
        {
            string classText = await GetLibMbinStateData();
            
            var results = new List<ClassVariable>();
            bool passedClassDefinition = false;
            foreach (var line in classText.Split('\n'))
            {
                if (line.Contains("class"))
                {
                    passedClassDefinition = true;
                    continue;
                }

                if (!passedClassDefinition)
                    continue;

                if (!line.Contains("*/"))
                    continue;

                var offsetSplit = line.Split("*/"); // offsetSplit by */
                var offsetText = offsetSplit[0].Replace("/", "").Replace("*", "").Replace("0x", "").Trim();
                bool acquiredOffset = int.TryParse(offsetText, style: NumberStyles.HexNumber, provider: null, out int offset);

                var variableSplit = offsetSplit[1].Split(" ");
                string variableName = variableSplit[variableSplit.Length - 1].Trim(' ').TrimEnd(';');

                string variableTypeName = variableSplit[variableSplit.Length - 2];
                var variableType = typeof(GcPlayerStateData).GetField(variableName)?.FieldType;

                var classVariable = new ClassVariable()
                {
                    Name = variableName,
                    Offset = offset,
                    VariableType = variableType,
                };

                results.Add(classVariable);
            }

            return results;
        }

        async Task<string> GetLibMbinStateData()
        {
            string url = "https://raw.githubusercontent.com/monkeyman192/MBINCompiler/development/libMBIN/Source/NMS/GameComponents/GcPlayerStateData.cs";
            using var client = new HttpClient();
            return await client.GetStringAsync(url);
        }

    }
}
