# Mod Functions!
This page contains info on the functions that come with your Mod.
These are located in your ``Mod.cs`` file, which is the file you will be in 99% of the time.
Examples include overridable methods like Awake, Update, OnMBinLoaded, OnGameJoined, etc.



### Update
A shortcut for writing code in the GameLoop.
The same as adding a listener to ``GameLoop.OnUpdate.Postfix``.
This can slow the game down so avoid using it if you can help it.


Code examples:
```cs
public override void Update()
{
    // code in here will run every frame.
}
```
```cs
public override void Update(double deltaTime)
{
    // code in here will run every frame. DeltaTime (time between frames) is provided for convenience.
}
```



### OnMainMenu
A shortcut for running code on the main menu.
The same as adding a listener to ``Game.OnMainMenu``.


Code example:
```cs
public override void OnMainMenu()
{
    // code in here will when you reach the main menu.
}
```



### OnGameJoined
A shortcut for running code when the player first joins the game after selecting a profile/save data.
The same as adding a listener to ``Game.OnGameJoined``.


Code example:
```cs
public override void OnGameJoined()
{
    // code in here will when you load into the game.
}
```



### SetValue and GetValue
A shortcut for getting/setting a value in memory, through the use of the Memory Manager.
This is convenient because you won't always have to do ``memory.BlahBlah`` to run your code.
The same as ``memory.SetValue`` or ``memory.GetValue``


Code example:
```cs
// example of getting the run speed from the player globals
float currentRunSpeed = GetValue<float>("GcPlayerGlobals.GroundRunSpeed");

// example of settng the run speed to twice it's original value.
SetValue("GcPlayerGlobals.GroundRunSpeed", currentRunSpeed * 2);
```