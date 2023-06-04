using System;
using System.Collections.Generic;

namespace NoMansSky.Api.Definitions;

public interface IContainer
{
    protected static Dictionary<Type, int> containerSizes = new Dictionary<Type, int>();
    protected static Dictionary<Type, int> elementSizes = new Dictionary<Type, int>();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public long GetPointer();

    /// <summary>
    /// Returns the total number of elements in this container.
    /// </summary>
    /// <returns></returns>
    int GetCount();

    /// <summary>
    /// Returns the total byte count of one element.
    /// <br/>Unless you're calculating element sizes you can ignore this.
    /// </summary>
    /// <returns></returns>
    public int GetElementByteSize();

    /// <summary>
    /// Returns the total byte count of this container.
    /// <br/>Unless you're calculating element sizes you can ignore this.
    /// </summary>
    /// <returns></returns>
    public int GetContainerByteSize();
}


public unsafe interface IContainer<T> : IContainer
{
    public T* this[int index]
    {
        get => GetElement(index);
        set => SetElement(index, value);
    }


    /// <summary>
    /// Returns the element stored at a particular index.
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    T* GetElement(int index);

    /// <summary>
    /// Set the value of an element at the specified index.
    /// </summary>
    /// <param name="index"></param>
    /// <param name="value"></param>
    void SetElement(int index, T* value);
}