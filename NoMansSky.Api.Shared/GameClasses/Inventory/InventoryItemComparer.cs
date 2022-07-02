using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// An item comparer for inventory items. Used to sort them by (x, y)
    /// </summary>
    public class InventoryItemComparer : IComparer<IInventoryItem>
    {
        public int Compare(IInventoryItem x, IInventoryItem y)
        {
            return x.Index.CompareTo(y.Index);
        }
    }
}
