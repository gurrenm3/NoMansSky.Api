### Crazy Planets!
Whenever a planet is loaded, this mod will make that planet CRAZY!


Code example:
```cs
CurrentSystem.OnPlanetLoaded.AddListener((planetAddress) =>
{
	MBinManager.ModifyMbin<GcPlanetData>(planetAddress, (planetData) =>
	{
		Logger.WriteLine($"Modding planet named: {planetData.Name.Value}");

		// change a bunch of random things
		planetData.Weather.RainbowType.RainbowType = GcRainbowType.RainbowTypeEnum.Always;
		planetData.CreatureLife.LifeSetting = GcPlanetLife.LifeSettingEnum.Full;
		planetData.Life.LifeSetting = GcPlanetLife.LifeSettingEnum.Full;
		planetData.PlanetInfo.IsWeatherExtreme = true;
		planetData.ResourceLevel = GcPlanetData.ResourceLevelEnum.High;

		// make all the colors random
		foreach (var pallete in planetData.Colours.Palettes)
		{
			foreach (var color in pallete.Colours)
			{
				// need to divide by 255 because it has to be between 0 and 1
				color.R = Random.Range(0, 255) / 255;
				color.G = Random.Range(0, 255) / 255;
				color.B = Random.Range(0, 255) / 255;
			}
		}
	});
});
```