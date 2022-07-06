# MBin Manager Functions!
This page contains info on the functions in the MBin Manager class.


### GetMBin
Will return a loaded MBin based on it's name.


Code examples:
```cs
// get an mbin with it's name
IMbin aiGlobals = MBinManager.GetMBin("GcAISpaceshipGlobals");

// get an mbin with it's type.
IMbin aiGlobals2 = MBinManager.GetMBin<GcAISpaceshipGlobals>();
```



### GetAllMBin
Returns all of the MBin files currently being managed.


Code example:
```cs
// get all managed mbins.
List<IMBin> managedMBins = MBinManager.GetAllMBin();

// example of looping over them to do things
foreach (IMbin mbin in managedMBins)
{
    Logger.WriteLine($"The MBin's name is: {mbin.Name}");
}
```



### GetMBinType
Returns the libMbin class Type for the mbin with the provided name. 

Code example:
```cs
Type typeFromLibMbin = MBinManager.GetMBinType("GcAISpaceshipGlobals");
```