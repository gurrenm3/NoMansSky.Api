using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetLife : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPlanetLife.LifeSettingEnum LifeSetting
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlanetLife.LifeSettingEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlanetLife.LifeSettingEnum>(value);
	}

	public GcPlanetLife(long address) : base(address)
	{

	}
}
