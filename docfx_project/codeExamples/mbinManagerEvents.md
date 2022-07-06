# MBin Manager Events!
This page contains info on events in the MBin Manager class


### OnMBinLoaded
Runs whenever an MBin is loaded/registered in the API.
This is not called for every MBin in the game and only works for the ones the API is aware of/tracking.


Code example:
```cs
MBinManager.OnMBinLoaded.AddListener((loadedMbin) =>
{
    string mbinName = loadedMbin.Name;
    long mbinAddress = loadedMbin.Address;

    if (mbinName == "GcPlayerGlobals")
    {
        // it's the globals!
    }
});
```