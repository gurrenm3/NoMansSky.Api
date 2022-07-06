using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// A manager for dealing with MBIN files.
    /// </summary>
    public interface IMBinManager
    {
        /// <summary>
        /// Called whenever an MBIN file is loaded into the game.
        /// </summary>
        IModEvent<IMBin> OnMBinLoaded { get; set; }

        /// <summary>
        /// Will return a loaded MBIN based on it's name.
        /// </summary>
        /// <param name="mbinName"></param>
        /// <returns></returns>
        IMBin GetMBin(string mbinName);

        /// <summary>
        /// Will return a loaded MBIN based on it's name. Get's name from type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IMBin GetMBin<T>();

        /// <summary>
        /// Returns all MBIN files that have been captured by the API.
        /// </summary>
        /// <returns></returns>
        List<IMBin> GetAllMBin();
    }
}
