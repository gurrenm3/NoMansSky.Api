using System;
namespace NoMansSky.Api.Definitions;

public interface IVirtualList
{
}

public interface IVirtualList<TElement> : IVirtualList, IContainer<TElement> where TElement :struct
{

}