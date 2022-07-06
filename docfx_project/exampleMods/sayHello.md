### Say Hello on Main Menu
This mod will say "Hello!" when you reach the main menu.


Code examples:
1. Using ModEvents
```cs
Game.OnMainMenu.AddListener(() =>
{
    Logger.WriteLine("Hello!");
});
```
2. Using Override Function
```cs
public override void OnMainMenu()
{
    Logger.WriteLine("Hello!");
}
```