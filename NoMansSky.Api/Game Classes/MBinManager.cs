using libMBIN.NMS.GameComponents;
using Reloaded.ModHelper;
using System.Collections.Generic;
using System.Linq;

namespace NoMansSky.Api
{
    /// <summary>
    /// A manager for dealing with MBIN files.
    /// </summary>
    public class MBinManager : IMBinManager
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<IMBin> OnMBinLoaded { get; set; } = new SharedModEvent<IMBin>();
        private List<IMBin> loadedMBIN = new List<IMBin>();

        public MBinManager()
        {
            OnMBinLoaded += (mbin) =>
            {
                loadedMBIN.Add(mbin);
            };
        }

        /// <summary>
        /// Returns a new list containing all of the loaded MBIN files.
        /// <br/>A new list is returned in order to prevent accidentally modifying the origninal list.
        /// </summary>
        /// <returns></returns>
        public List<IMBin> GetAllMBIN()
        {
            List<IMBin> mbin = new List<IMBin>();
            mbin.AddRange(loadedMBIN);
            return mbin;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="mbinName"></param>
        /// <returns></returns>
        public IMBin GetMbin(string mbinName)
        {
            mbinName = mbinName.ToLower();
            foreach (var mbin in loadedMBIN)
            {
                var currentMbinName = mbin.Name.ToLower();
                if (mbinName == currentMbinName || mbinName == currentMbinName.Insert(0, "gc") || mbinName.Insert(0, "gc") == currentMbinName || mbinName == currentMbinName.Insert(0, "cgc") || mbinName.Insert(0, "cgc") == currentMbinName)
                {
                    return mbin;
                }
            }

            return null;



            /*var mbin = loadedMBIN?.FirstOrDefault(mbin => mbin?.Name.ToLower() == mbinName);
            if (mbin == null)
            {
                mbinName = mbinName.Insert(0, "gc"); // try adding gc to the front 
                mbin = loadedMBIN?.FirstOrDefault(mbin => mbin?.Name.ToLower() == mbinName);
            }
            if (mbin == null)
            {
                mbinName = mbinName.Insert(0, "c"); // try adding c to the front so it's cgc
                mbin = loadedMBIN?.FirstOrDefault(mbin => mbin?.Name.ToLower() == mbinName);
            }
            return mbin;*/
        }
    }
}
