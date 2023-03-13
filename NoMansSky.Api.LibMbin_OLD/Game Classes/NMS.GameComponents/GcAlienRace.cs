using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAlienRace : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcAlienRace.AlienRaceEnum AlienRace
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAlienRace.AlienRaceEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAlienRace.AlienRaceEnum>(value);
	}

	public GcAlienRace(long address) : base(address)
	{

	}
}
