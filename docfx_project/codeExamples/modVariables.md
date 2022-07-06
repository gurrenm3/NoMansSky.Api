# Mod Variables!
This page contains info on the variables that come with your Mod.
These are located in your ``Mod.cs`` file, which is the file you will be in 99% of the time.
Examples include instances of the Game, Player, CurrentSystem, GalaxyMap, etc.


### Logger
The instance of the ModLogger that you can use to send messages to the Console.
You will use this very often.


Code example:
```cs
Logger.WriteLine("Hello World");
```


### Game
The instance of the Game class.
Since all features of the API are connected to this, you will use it very often.
The same as ``IGame.Instance``.


Code example:
```cs
bool inGame = Game.IsInGame;
```



### GameLoop
The instance of the NMS Game Loop.
The GameLoop is connected to No Man's Sky's actual game loop and will run every frame.
It's a ModEventHook so you can control whether to run your code before/after the actual game loop.
Useful for Keyboard/Mouse checks, or waiting for a condition to be true.
The same as ``Game.GameLoop``.


Code example:
```cs
GameLoop.OnUpdate.Postfix.AddListener(() =>
{
    if (Keyboard.IsPressed(Key.UpArrow))
    {
        // the up arrow was pressed!
    }
});
```



### Player
The instance of the Player class.
Contains info about the player, like they're health, units, etc.
The same as ``Game.Player``.


Code example:
```cs
int units = Player.Units.Value;
```



### MBinManager
A shortcut for accessing the MBinManager.
The same as using ``Game.MBinManager``.


Code example:
```cs
MBinManager.ModifyMbin<GcPlayerGlobals>((playerGlobals) =>
{
    playerGlobals.GroundRunSpeed = 20;
});
```



### memory
An instance of the Memory Manager.
Useful for modding mbin files and other values in memory.


Code example:
```cs
// example of getting the run speed from the player globals
float currentRunSpeed = memory.GetValue<float>("GcPlayerGlobals.GroundRunSpeed");

// example of settng the run speed to twice it's original value.
memory.SetValue("GcPlayerGlobals.GroundRunSpeed", currentRunSpeed * 2);
```



### More
The API has a decent amount of other variables you can access, however most will either be irrelevant for your needs, are a place holder/WIP, or will be replaced soon.