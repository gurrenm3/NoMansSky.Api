### Modding Global Mbins
This mod demonstrates a few of ways you can use the MemoryManager and MBinManager to mod globals.


Code examples:
1. Using override method
```cs
public override void OnMBinLoaded(IMBin loadedMbin)
{
    if (loadedMbin.Name == "GcAISpaceshipGlobals")
    {
        var globals = GetValue<GcAISpaceshipGlobals>(loadedMbin.Address);
        globals.FreighterScale = 1.5f; // change freighter scale
        SetValue(loadedMbin.Address, globals);
    }
    else if (loadedMbin.Name == "GcPlayerGlobals")
    {
        MBinManager.ModifyMbin<GcPlayerGlobals>((playerGlobals) =>
        {
            playerGlobals.GroundRunSpeed = 30;
        });
    }
}
```
2. Using mod event
```cs
MBinManager.OnMBinLoaded.AddListener((loadedMbin) =>
{
    if (loadedMbin.Name == "GcAISpaceshipGlobals")
    {
        var globals = GetValue<GcAISpaceshipGlobals>(loadedMbin.Address);
        globals.FreighterScale = 1.5f; // change freighter scale
        SetValue(loadedMbin.Address, globals);
    }
    else if (loadedMbin.Name == "GcPlayerGlobals")
    {
        MBinManager.ModifyMbin<GcPlayerGlobals>((playerGlobals) =>
        {
            playerGlobals.GroundRunSpeed = 30;
        });
    }
});```