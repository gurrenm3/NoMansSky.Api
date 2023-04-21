namespace NoMansSky.Api.Definitions;

public interface IVirtualAllocator<T> where T : struct
{
    /// <summary>
    /// 
    /// </summary>
    public int Alignment { get; }

    /// <summary>
    /// 
    /// </summary>
    public int Pool { get; }
}
