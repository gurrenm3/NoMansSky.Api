using libMBIN;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    internal class PakManager
    {
        Assembly libmbinAssembly;
        public Dictionary<string, string> mbinPathsAndTypes = new Dictionary<string, string>();

        public PakManager()
        {
            libmbinAssembly = typeof(NMSTemplate).Assembly;
        }

        public Type GetMbinType(string filePath)
        {
            mbinPathsAndTypes.TryGetValue(filePath, out string mbinTypeName);
            if (string.IsNullOrEmpty(mbinTypeName))
                return null;

            return libmbinAssembly.GetTypes().FirstOrDefault(type => type.Name == mbinTypeName);
        }

        public void LoadFromDirectory(string directory)
        {
            var pakFiles = Directory.GetFiles(directory, "*.pak");
            foreach (var file in pakFiles)
            {
                using var fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                PakFile pak = new PakFile(file);
                if (!pak.Init())
                    continue;

                //Mod.WriteLine($"Registering mbins from {file.Replace(IGame.instance.NMSDirectory, "").Trim('\\')}");
                var mbinFiles = pak.Entries.FindAll(entry => !string.IsNullOrEmpty(entry.MbinType));
                foreach (var mbin in mbinFiles)
                {
                    mbinPathsAndTypes.TryAdd(mbin.Path, mbin.MbinType);
                }
            }
        }
    }
}
