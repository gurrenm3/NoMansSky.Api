# Game Events!
This page contains info on events that relate to the general game.
Examples include OnMainMenu, OnProfileSelected, etc.


### OnMainMenu
Runs whenever the main menu is reached.
This is useful if you want to run code early on.


Code example:
```cs
Game.OnMainMenu.AddListener(() =>
{
    // your code here.
});
```


### OnProfileSelected
Runs when the player selects a profile/save data to play on.
Useful for modding the player before they finish loading into the game.


Code example:
```cs
Game.OnProfileSelected.AddListener(() =>
{
    // your code here.
});
```


### OnGameJoined
Runs when the player finishes loading into the game after having selected a profile to play on.
Useful for modding mbins or other game files, the player, the planet the player is on, etc.


Code example:
```cs
Game.OnGameJoined.AddListener(() =>
{
    // your code here.
});
```


### OnWarpStarted
Runs when the player first starts warping. Does not distinguish what type of warp it is.
Useful for modding the planet/solar system the player is loading into.


Code example:
```cs
Game.OnWarpStarted.AddListener(() =>
{
    // your code here.
});
```


### OnWarpFinished
Runs when the player finishes warping into a new system.
Useful for modding the planet/solar system the player is loading into.


Code example:
```cs
Game.OnWarpFinished.AddListener(() =>
{
    // your code here.
});
```


### OnInventoryOpened
Runs when the player opens the inventory screen.
Useful for modding the inventory and it's items.


Code example:
```cs
Game.OnInventoryOpened.AddListener(() =>
{
    // your code here.
});
```


### OnInventoryClosed
Runs when the player closes the inventory screen.
Useful for modding the inventory and it's items.


Code example:
```cs
Game.OnInventoryClosed.AddListener(() =>
{
    // your code here.
});
```