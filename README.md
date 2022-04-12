# NoMansSky.API
A C# modding API for the game No Mans Sky.
Built with [Reloaded II](https://github.com/Reloaded-Project), an extremely powerful set of modding tools.

**IMPORTANT:**
This project is a work in progress and will likely have breaking changes in the future.

## What is this project?
This project is an API for modding No Mans Sky. It's purpose is to help mod makers create crazy powerful mods that would otherwise be very impossible. At a high level, all this project does is use memory modding techniques and hooking to expose No Mans Sky to a C# API that other modders can use.

## Current Features
- Several events like OnMainMenu, OnProfileSelected, OnGameJoined, etc.
- The NMS Game Loop is hooked so you can run your code OnUpdate, once every frame.
- Ability to get/set basic player stats: Units, Nanites, Quicksilver, Health, Shield.
- OnValueChanged event for the stats mentioned above. This event can be used to change the value it would have been.
- Limited support for modding Player inventories
- A wrapper class for adding your adding more Stats to the game.
- Everything has been setup to allow you to make your own version of things from the API. Examples:
   - Make your own Hooks
   - Make your own ModEvents
   - Make your own Attributes
   - Do your own Signature Scanning
   - Publish your own code for other mods to use
   - Etc
- An insane amount of backend support for general modding stuff. Examples:
   - A highly customized ``ModEvent`` class for broadcasting events from the game or effortlessly creating your own hooks.
   - Support for "stupid simple" signature scanning. It's literally ``new Signature().Scan();``
   - Hooks using the ``IModHook`` interface are automatically registered.
   - A custom ``Attribute`` class called ``ModAttrAttribute`` which is automatically registered and can do anything you want.
   - Keyboard/Mouse/Screen info
   - Vector2, Vector3
   - Much more
- Every feature has been meticulously planned to guarantee maximum ease of use without impacting performance.
   - All NMS API code will also work seamlessly with multiple mods active. It's designed to prevent modders from accidentally breaking things for the player or other mods.

## How to get started?
In order to mod NMS in this diverse way, we must use Memory Modding techniques. That's programmer talk for "it's damn difficult". We'd normally have to do **a ton** of ground work just to make our mods barely possible. Luckily, a suite of amazing Memory Modding tools exists that does all of the work for us. This set of tools is called [Reloaded2](https://github.com/Reloaded-Project). These tools are truly powerful and incredibly well made, which is why this API depends on them. To get started, you will need to:

1. Download [Steamless.exe](https://github.com/atom0s/Steamless/releases/latest). This is needed to remove SteamDRM from No Mans Sky.
2. Run Steamless on NMS.exe, located in the ``Binaries`` folder of the No Man's Sky game directory. Ex: ``Steam\steamapps\common\No Man's Sky\Binaries``. Basically, just browse for ``NMS.exe`` and then click ``Unpack File`` at the bottom of Steamless
4. Download the latest version of the [Reloaded2 Mod Manager](https://github.com/Reloaded-Project/Reloaded-II/releases/latest). The installer is recommended since it does the work for you.
5. Open up the Reloaded Mod Manager. On the left side of the screen is a ``+`` plus button. Click that to add a game to the manager. Browse for the unpacked EXE file created by Steamless: ``NMS.exe.unpacked.exe``. It will be in the same ``Binaries`` folder as before. It is now added to the mod manager.
6. Download the latest version of NoMansSky.Api, which can be found [Here](https://github.com/gurrenm3/NoMansSky.Api/releases/latest)
7. Extract the zip file to your Reloaded2 Mod's folder. It's usually located on your Desktop. Ex: ``C:\Users\thomas\Desktop\Reloaded-II\Mods``. Make sure it extracts so everything is inside of the ``NoMansSky.Api`` folder. Ex: ``C:\Users\thomas\Desktop\Reloaded-II\Mods\NoMansSky.Api``
8. You're ready to play No Mans Sky with mods!

## For Developers
If you want to make mods with NoMansSky.Api, you'll need to follow all of the same steps above. Then all you need to do is use this [Mod Template](https://github.com/gurrenm3/NoMansSky.ModTemplate) to make your first mod! It's as easy as clicking the green "Use This Template" button at the top of the page.

## Planned features
Some features that are coming soon are:

- Better ability to manipulate items and inventories
- Custom items
- More than 3 multi-tools
- More than 1 freighter
- Custom UI
- Player Trading
