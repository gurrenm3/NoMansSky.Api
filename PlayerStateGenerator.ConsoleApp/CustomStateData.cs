/*using libMBIN;
using libMBIN.NMS.GameComponents;
using Newtonsoft.Json.Linq;
using Reloaded.ModHelper;
using static libMBIN.NMS.GameComponents.GcInventoryClass;

namespace PlayerStateGenerator.ConsoleApp;

public unsafe class CustomStateData : MbinClass<GcPlayerStateData>
{
    // an example of a more complex property like a whole class as the data type.
    public GcInventoryContainer StateData
    {
        get => cache.GetOrAddValue(new GcInventoryContainer());
        set
        {
            if (value == StateData)
                return;

            ChangePropertyValue(value, newValue => cache.AddOrUpdateValue(newValue));
        }
    }

    // an example of a simple property like player units.
    public int Units
    {
        get => *(int*)(address + GetOffset());
        set
        {
            if (value == Units)
                return;

            ChangePropertyValue(value, (newValue) => *(int*)(address + GetOffset()) = (int)newValue);
        }
    }

    public CustomStateData(long address) : base(address)
    { 

    }
}
*/