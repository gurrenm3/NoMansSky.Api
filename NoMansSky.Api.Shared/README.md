# NoMansSky.Api.Shared

This project contains all of the backend code for NoMansSky.Api.

Due to the nature of Reloaded2, any code that is published using ``IModLoader.AddOrReplaceController()`` for use with other mods must be contained within a separate project that has **zero** third party dependencies. It will not work otherwise. That's why this project exists. It contains all of the code that can be published using ``IModLoader.AddOrReplaceController()``, in other words pretty much all of the code backend code for the API
