using System;
using System.Collections.Generic;

namespace NoMansSky.Api.Definitions;

public unsafe interface IVirtualArray
{
    protected static Dictionary<Type, int> sizes = new();
}

public unsafe interface IVirtualArray<TElement, TSize> : IVirtualArray, IContainer<TElement>, IContainer where TElement : struct where TSize : ISize
{
    
}
