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
In order to mod NMS in this diverse way, we must use Memory Modding techniques. That's programmer talk for "it's damn difficult". We'd normally have to do **a ton** of ground work just to make our mods barely possible. Luckily, a suite of amazing Memory Modding tools exists that does all of the work for us. This set of tools is called [Reloaded2](https://github.com/Reloaded-Project). These tools are truly powerful and incredibly well made, which is why this API depends on them. To get started you will first need to download the latest version of the [Reloaded2 Mod Manager](https://github.com/Reloaded-Project/Reloaded-II/releases/latest). 

## Planned features
Some features that are coming soon are:

- Better ability to manipulate items and inventories
- Custom items
- More than 3 multi-tools
- More than 1 freighter
- Custom UI
- Player Trading
