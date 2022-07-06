### Random Units
This mod will give the player random units when they press the down arrow.


Code examples:
1. Using ModEvents
```cs
GameLoop.OnUpdate.Postfix.AddListener(() =>
{
    if (Keyboard.IsPressed(Key.DownArrow))
    {
        int unitsToAdd = Random.Range(0, 10000); // random number between 0 and 10,000
        Player.Units.Value += unitsToAdd;
    }
});
```
2. Using Override Function
```cs
public override void Update()
{
    if (Keyboard.IsPressed(Key.DownArrow))
    {
        int unitsToAdd = Random.Range(0, 10000); // random number between 0 and 10,000
        Player.Units.Value += unitsToAdd;
    }
}
```