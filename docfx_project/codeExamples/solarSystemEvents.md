# Solar System Events!
This page contains info on events in the Galaxy Map class.



### OnPlanetLoaded
While the player is loading into a solar system, this will run everytime a planet has just finished loading.
You will use this very often to mod planets since some things can only be done during warp.
It passes the planet's address as an argument.


Code example:
```cs
// called whenever a planet gets loaded.
CurrentSystem.OnPlanetLoaded.AddListener((planetAddress) =>
{
    // use the address to modify this planet
    CurrentSystem.ModifyPlanet(planetAddress, (planetData) =>
    {
        planetData.BuildingLevel.BuildingDensity = GcBuildingDensityLevels.BuildingDensityEnum.Weird;
    });
});
```


### OnSystemLoaded
This is called whenever you warp into a new system.
It passes the system's address as an argument.


Code example:
```cs
// called whenever you warp in.
CurrentSystem.OnSystemLoaded.AddListener((systemAddress) =>
{
    // get this system's data
    GcSolarSystemData systemData = GetValue<GcSolarSystemData>(systemAddress);
                
    // mod it
    systemData.MaxNumFreighters = 3;

    // apply changes to system
    SetValue(systemAddress, systemData);
});
```