# NoMansSky.API

[![Supported by the No Man's Sky Community Developers & Designers](https://raw.githubusercontent.com/NMSCD/About/master/badge/purple.svg)](https://github.com/NMSCD)

A C# modding API for the game No Mans Sky.
Built with [Reloaded II](https://github.com/Reloaded-Project), an extremely powerful set of modding tools. This project is also heavily dependent on [Reloaded.ModHelper](https://github.com/gurrenm3/Reloaded.ModHelper). It contains all of the general modding tools that the API relies on.

**IMPORTANT:**
This project is a work in progress and may have breaking changes in the future.

-----

## What is this project?
This project is an API for modding No Mans Sky. It's purpose is to help mod makers create crazy powerful mods that would otherwise be very impossible. At a high level, all this project does is use memory modding techniques and hooking to expose No Mans Sky to a C# API that other modders can use.

-----

## Current Features
- Complete control of all 20 Global MBin files
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

-----

## How to get started?
In order to mod NMS in this new and diverse way, we must use Memory Modding techniques. That's programmer talk for "it's damn difficult". We'd normally have to do a ton of ground work just to make our mods barely possible. Luckily, a suite of amazing Memory Modding tools exists that does all of the work for us. This set of tools is called Reloaded2. These tools are truly powerful and incredibly well made, which is why this API depends on them. To get started, you will need to do either of the following:

__For Mod Developers__:

A. Remove DRM from NMS.exe for debugging/breakpoint functionality etc.

1) Download Steamless.exe. This is needed to remove SteamDRM from No Mans Sky. (This will allow for adding breakpoints in your custom code for testing/debugging)
2) Run Steamless on NMS.exe, located in the Binaries folder of the No Man's Sky game directory. Ex: `Steam\steamapps\common\No Man's Sky\Binaries`. Basically, just browse for NMS.exe and then click Unpack File at the bottom of Steamless.
3) You can run Steamless with the default options selected, it will not affect your mod in anyway.

B. Install Reloaded2 Mod Manager
1) Download the latest version of the Reloaded2 Mod Manager. The installer is recommended since it does all the work for you. Link to installer: https://github.com/Reloaded-Project/Reloaded-II/releases/
2) Open up the Reloaded Mod Manager. On the left side of the screen is a + plus button. Click that to add a game to the manager. Browse for the unpacked EXE file created by Steamless: `NMS.exe.unpacked.exe`. It will be in the same Binaries folder as before. It is now added to the mod manager.

C. Get the NoMansSky.Api
1) All mods made with Reloaded2 will require the use of NoMansSky.Api. It comes with all the tools you'll need to make your mods. You can get the latest version [Here](https://github.com/gurrenm3/NoMansSky.Api/releases/latest). On this page you will see a section titled "Assets". This is where you'll download the API. You'll see a few different files to choose from. The only one you need is the one named "NoMansSky.Api.zip". Click that and download it, you can ignore the rest.
2) Extract the zip file to your Reloaded2 Mod's folder. It's usually located on your Desktop. `Ex: C:\Users\Thomas\Desktop\Reloaded-II\Mods`. Make sure it extracts so everything is inside of the NoMansSky.Api folder. Ex: `C:\Users\Thomas\Desktop\Reloaded-II\Mods\NoMansSky.Api`. __**NOTE**__: Make sure you didn't accidentally extract it like this "C:\Users\Thomas\Desktop\Reloaded-II\Mods __\NoMansSky.Api\NoMansSky.Api__". It can't be inside of 2 "NoMansSky.Api" folders. 
3) If NoMansSky.Api isn't loading at all when you run the game, try the following steps: In the Reloaded2 Mod Manager window, click the button with 3 gears on it, select Api from the list and make sure it is selected for No Man's Sky. Image for reference: https://imgur.com/a/TuZuPmU
4) You're ready to play with and develop mods for No Mans Sky!
5) To make your own mods you can use the NoMansSky Mod Template. It's a template or "starter mod" is already fully setup and ready to be used for your own projects. [You can download the Mod Template here](https://github.com/gurrenm3/NoMansSky.ModTemplate)! Using it is as easy as clicking the green "Use This Template" button at the top of the page.



__For Players:__

A. Install Reloaded2 Mod Manager
1) Download the latest version of the Reloaded2 Mod Manager. The installer is recommended since it does all the work for you. Link to installer: https://github.com/Reloaded-Project/Reloaded-II/releases/
2) Open up the Reloaded Mod Manager. On the left side of the screen is a + plus button. Click that to add a game to the manager. Browse for the No Mans Sky exe file, `NMS.exe`. It is located in the Binaries folder of the No Man's Sky game directory. Ex: `Steam\steamapps\common\No Man's Sky\Binaries`. Once you select the EXE it is now added to the mod manager.

B. Get the NoMansSky.Api
1) All mods made with Reloaded2 will require the use of NoMansSky.Api. It comes with all the tools that modders need to create their mods. You can get the latest version [Here](https://github.com/gurrenm3/NoMansSky.Api/releases/latest). On this page you will see a section titled "Assets". This is where you'll download the API. You'll see a few different files to choose from. The only one you need is the one named `NoMansSky.Api.zip`. Click that and download it, you can ignore the rest.
2) Extract the zip file to your Reloaded2 Mod's folder. It's usually located on your Desktop. `Ex: C:\Users\Thomas\Desktop\Reloaded-II\Mods`. Make sure it extracts so everything is inside of the `NoMansSky.Api folder. Ex: C:\Users\Thomas\Desktop\Reloaded-II\Mods\NoMansSky.Api`. __**NOTE**__: Make sure you didn't accidentally extract it like this "C:\Users\Thomas\Desktop\Reloaded-II\Mods __\NoMansSky.Api\NoMansSky.Api__". It can't be inside of 2 "NoMansSky.Api" folders. 

C. Download the mods that use the Api.
1) Download the latest version of any mod that uses the NoMansSky.Api. Lets call it "Mod_made_using_the_API"
2) Extract the zip file to your Reloaded2 Mod's folder, located on your Desktop. Ex: `C:\Users\Thomas\Desktop\Reloaded-II\Mods`. Make sure it extracts so everything is inside of the "Mod_made_using_the_API" folder ( the folder name should be the name of the mod) Ex: `C:\Users\Thomas\Desktop\Reloaded-II\Mods\Mod_made_using_the_API`. Again, make sure the mod isn't in the "Mod_made_using_the_API" folder twice, like mentioned above with the Api.
3) Repeat for however many mods you want to use.
4) Make sure the API and the mods are selected in the Reloaded2 Mod Manager window, else the game wont use the mods nor the API.
5) If your mod isn't loading at all when you run the game, try the following steps: In the Reloaded2 Mod Manager window, click the button with 3 gears on it, select the mod name from the list and make sure it is selected for No Man's Sky. Image for reference: https://imgur.com/a/TuZuPmU

You're ready to play No Mans Sky with mods! 

After your mods are enabled press the "Launch Application" button to run the game with your mods. You need to do this because if you don't start it from Reloaded your mods won't be used. If you're stuck you can check this image for reference: [https://imgur.com/a/8uUpa7G](https://imgur.com/a/8uUpa7G)

-----

## Planned features
Some features that are coming soon are:

- Access to more stats from the Player, Ship, Freighter, Exosuit, and MultiTool
- Better ability to manipulate items and inventories
- Custom items
- More than 3 multi-tools
- More than 1 freighter
- Custom UI
- Player Trading
