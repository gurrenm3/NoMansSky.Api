# Game Loop Events!
This page contains info on events in the Game Loop class.



### OnUpdate
This is called every frame the game updates (many times a second).
It's hooked to the actual game loop of No Man's Sky so your mods will be in sync with the game.
This can slow the game down so avoid using it if you can help it.


Code examples:
```cs
// this is a prefix so it will run before the game starts the loop
GameLoop.OnUpdate.Prefix.AddListener(() =>
{
    
});
```
```cs
// this is a postfix so it will run after the game finishes the loop
GameLoop.OnUpdate.Postfix.AddListener(() =>
{

});
```