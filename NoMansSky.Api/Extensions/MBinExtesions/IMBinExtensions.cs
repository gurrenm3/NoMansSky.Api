using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="IMBin"/>.
    /// </summary>
    public static class IMBinExtensions
    {
        /// <summary>
        /// Returns whether or not this mbin is representing a globals file.
        /// </summary>
        /// <param name="mbin"></param>
        /// <returns></returns>
        public static bool IsGlobalMbin(this IMBin mbin)
        {
            return mbin.Name.EndsWith("Globals");
        }
    }
}
