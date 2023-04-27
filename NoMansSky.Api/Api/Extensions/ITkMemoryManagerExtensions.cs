namespace NoMansSky.Api;

public static unsafe class ITkMemoryManagerExtensions
{
    public static cTkMemoryManager* GetTkMemoryManager(this ITkMemoryManager instance)
    {
        return (cTkMemoryManager*)IGame.Instance.TkMemoryManager.Pointer;
    }
}
