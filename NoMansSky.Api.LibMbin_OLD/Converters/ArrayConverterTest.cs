using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMansSky.Api.LibMbin.Converters
{
    public class ArrayConverterTest : IMemoryConverter
    {
        public bool CanConvert(Type typeToCheck)
        {
            throw new NotImplementedException();
        }

        public bool CanConvert<T>()
        {
            throw new NotImplementedException();
        }

        public Array GetValue(long address, Type arrayType, int arrayLength)
        {
            throw new NotImplementedException();
        }

        public object GetValue(long address, Type valueType)
        {
            throw new NotImplementedException();
        }

        public T GetValue<T>(long address)
        {
            throw new NotImplementedException();
        }

        public void SetValue(long address, object valueToSet)
        {
            throw new NotImplementedException();
        }
    }
}
