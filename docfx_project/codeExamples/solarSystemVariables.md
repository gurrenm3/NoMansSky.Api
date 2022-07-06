# Solar System Variables!
This page contains info on the variables in the Solar System class.


### System Address
The address of the current solar system.
Can be used to get GcSolarSystemData. Currently only works after warping at least once.


Code examples:
1. Using address with ModifyMbin
```cs
long address = CurrentSystem.SystemAddress; // here is the address

// use address to mod system.
MBinManager.ModifyMbin<GcSolarSystemData>(address, (systemData) =>
{
    systemData.AsteroidLevel = GcSolarSystemData.AsteroidLevelEnum.LotsOfRares;
});
```

2. Using address with memory manager
```cs
// get system address
long address = CurrentSystem.SystemAddress;

// create GcSolarSystemData out of it
GcSolarSystemData systemData = memory.GetValue<GcSolarSystemData>(address);

// make your mod
systemData.ConflictData.ConflictLevel = GcPlayerConflictData.ConflictLevelEnum.High;

// apply the changes to the address in memory
memory.SetValue(address, systemData);
```



### Planet Addresses
Contains the addresses of all of the planets in this system.
Used to mod planets.


Code examples:
1. using the planet addresses with ModifyMbin
```cs
// get the addresses
List<long> planetAddresses = CurrentSystem.PlanetAddresses;

// can now mod the planets now that you have their address in memory.
foreach (var address in planetAddresses)
{
    MBinManager.ModifyMbin<GcPlanetData>(address, (planetData) =>
    {
        planetData.ResourceLevel = GcPlanetData.ResourceLevelEnum.High;
    });
}
```
2. using the planet addresses Get/Set PlanetData
```cs
// get the addresses
List<long> planetAddresses = CurrentSystem.PlanetAddresses;

foreach (var address in planetAddresses)
{
    // use the address to get the actual GcPlanetData
    GcPlanetData planetData = CurrentSystem.GetPlanetData(address);

    // make some changes
    planetData.FuelMultiplier = 0;

    // apply changes back to the game
    CurrentSystem.SetPlanetData(address, planetData);
}
```