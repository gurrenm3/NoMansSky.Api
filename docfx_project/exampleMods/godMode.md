### God Mode
This mod will make it so whenever you're about to take damage, your health will not change, giving you god mode!


Code examples:
```cs
// newValue is what our health would be after this runs. We're going to make it so it never goes lower!
Player.Health.OnValueChanged.Prefix.AddListener((newValue) =>
{
    if (newValue.value < Player.Health)
    {
        newValue.value = Player.Health; // our new health will be our current health. Take no damage!
    }
});
```