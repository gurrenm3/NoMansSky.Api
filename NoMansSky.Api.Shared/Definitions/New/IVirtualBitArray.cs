
namespace NoMansSky.Api.Definitions;

public interface IVirtualBitArray<TElement, TSize> : IContainer where TElement : struct where TSize : ISize
{
    public bool this[int index]
    {
        get => GetElement(index);
        set => SetElement(index, value);
    }

    bool GetElement(int index);
    void SetElement(int index, bool value);
    int GetNumTrue();
    void SetFirstNBitsTrue(int amount);
    void SetAllElements(bool value);
}
