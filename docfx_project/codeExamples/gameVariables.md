# Game Variables!
This page contains info on the variables that relate to the general game.
Examples include IsOnMainMenu, IsInGame, IsWarping, etc.


### IGame.Instance
The static instance of the Game class.
Very helpful for bigger mods that are spread out over multiple classes.
Every variable, function, and event in the Game class can be accessed from this.
This is the same `Game` variable as the one your mods normally use.


Code examples:
```cs
bool isWarping = IGame.Instance.IsWarping; // reflects whether or not we're warping right now.
```
```cs
IGame.Instance.OnMainMenu.AddListener(() =>
{
    // your code here.
});
```



### MBinManager
A manager/container for all of the MBIN files the API is tracking.
Useful for modding mbin files.


Code example:
```cs
var mbin = Game.MBinManager.GetMbin("GcPlayerGlobals"); // gets the mbin for GcPlayerGlobals
var mbinAddress = mbin.Address; // the globals are located here
```



### Player
Represents the current Player that is playing the game.
Very useful for any mods that deal with the player, their stats, or their inventory.


Code example:
```cs
int currentUnits = Game.Player.Units.Value; // how much money the player has.
Game.Player.Units.Value = 999999999; // infinite money
```



### CurrentSystem
Represents the solar system that the player is currently in.
Useful for modding the current solar system or the planets in it.


Code example:
```cs
List<GcPlanetData> planetsInSystem = Game.CurrentSystem.GetPlanets(); // get all the planets in this system.
```



### GalaxyMap
An instance of the Galaxy Map that is being managed by the API.
Useful for getting information about the galaxy map.


Code example:
```cs
bool isMapOpened = Game.GalaxyMap.IsOpened; // reflects whether or not the galaxy map is currently opened.
```



### IsOnMainMenu
Reflect whether or not the player is currently on the main menu.
Cannot be manually changed since it just tells you about the state of the game.
Useful for running code only when the player is on the main menu.


Code example:
```cs
bool isOnMainMenu = Game.IsOnMainMenu; // reflects whether or not the player is currently on the main menu.
```



### IsProfileSelected
Reflect whether or not the player has already selected a profile/save data to play on.
Cannot be manually changed since it just tells you about the state of the game.
Useful for running code only after the player has selcted a save file.


Code example:
```cs
bool isSelected = Game.IsProfileSelected; // reflects whether or not the player has selected a profile/save game yet.
```



### IsLoadingIntoGame
Reflect whether or not the player is currently loading into the game after selecting a profile/save data.
Cannot be manually changed since it just tells you about the state of the game.
Useful for running code while the game is loading for the first time, or modding the solar system the player will load into.


Code example:
```cs
bool isLoadingSaveFile = Game.IsLoadingIntoGame; // reflects whether or not the player is currently loading into the game.
```



### IsInGame
Reflect whether or not the player has loaded into the game after selecting a profile to play on.
Cannot be manually changed since it just tells you about the state of the game.
Useful for running code only after the player has loaded into the game.


Code example:
```cs
bool ingame = Game.IsInGame; // reflects whether or not the player has loaded into the game.
```



### IsWarping
Reflect whether or not the player is currently warping. Does not distinguish the type of warp.
Cannot be manually changed since it just tells you about the state of the game.
Useful for running code only while warping or modding the system the player is loading into.


Code example:
```cs
bool warping = Game.IsWarping; // reflects whether or not the player is currently warping.
```



### IsInventoryOpen
Reflect whether or not the player currently has the inventory screen up.
Cannot be manually changed since it just tells you about the state of the game.
Useful for modding the inventory or identifying if they have any UI menu showing.


Code example:
```cs
bool isOpened = Game.IsInventoryOpen; // reflects whether or not the player is currently veiwing their inventory.
```