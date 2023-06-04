using System;
using System.Collections.Generic;

namespace NoMansSky.Api.Definitions;

public interface IVirtualString<TSize> : IVirtualString where TSize : ISize
{
    
}

public interface IVirtualString
{
    protected static Dictionary<Type, int> sizes = new();

    int GetMaxLength();
    long GetPointer();
    string GetValue();
    char GetValue(int index);
    void SetValue(string newValue);
}
