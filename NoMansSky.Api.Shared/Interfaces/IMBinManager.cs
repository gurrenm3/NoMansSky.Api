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
        /// Will return the a loaded MBIN based on it's name.
        /// </summary>
        /// <param name="mbinName"></param>
        /// <returns></returns>
        IMBin GetMbin(string mbinName);

        /// <summary>
        /// Returns all MBIN files that have been captured by the API.
        /// </summary>
        /// <returns></returns>
        List<IMBin> GetAllMBIN();

        /// <summary>
        /// Returns the Type of the mbin 
        /// </summary>
        /// <param name="mbinName"></param>
        /// <returns></returns>
        Type GetMbinType(string mbinName);
    }
}
