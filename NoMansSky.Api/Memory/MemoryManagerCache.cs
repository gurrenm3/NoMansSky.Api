using libMBIN;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NoMansSky.Api
{
    internal class MemoryManagerCache
    {
        internal struct MemoryInfo
        {
            public long address;
            public Type objectType;
        }

        private Dictionary<string, MemoryInfo> addressCache = new Dictionary<string, MemoryInfo>();
        private static IMBinManager MBinManager => IGame.Instance?.MBinManager;

        public MemoryManagerCache()
        {
             
        }

        public MemoryInfo GetAddressInfo(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                ConsoleUtils.LogError("Tried getting the address of an empty path.");
                return default;
            }    

            if (addressCache.TryGetValue(path, out var memInfo))
                return memInfo;

            if (MBinManager == null)
            {
                ConsoleUtils.LogError("Error! MBinManager is null! This is not suppose to happen!");
                return default;
            }    

            // create path array.
            string[] pathSplit = path.Contains(".") ? path.Split('.') : pathSplit = new string[1] { path };
            string mbinName = pathSplit[0];
            var mbin = MBinManager.GetMBin(mbinName);
            if (mbin == null)
            {
                ConsoleUtils.LogError($"Failed to get mbin with the name of \"{mbinName}\"");
                return default;
            }

            var currentType = mbin.MBinType;
            if (currentType == null)
            {
                ConsoleUtils.LogError($"Failed to get the type for the mbin with the name of \"{mbinName}\"");
                return default;
            }

            // code below is getting offsets from each variable. Haven't checked arrays/lists yet.
            long currentAddress = mbin.Address;
            for (int i = 1; i < pathSplit.Length; i++)
            {
                string className = currentType.Name;
                string fieldName = pathSplit[i];

                int offset = NMSTemplate.OffsetOf(className, fieldName);
                currentAddress += offset;
                currentType = currentType?.GetField(fieldName).FieldType;
            }

            memInfo = new MemoryInfo() { objectType = currentType, address = currentAddress };
            addressCache.Add(path, memInfo);
            return memInfo;
        }
    }
}
