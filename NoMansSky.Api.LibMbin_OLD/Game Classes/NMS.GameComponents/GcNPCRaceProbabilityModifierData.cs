using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCRaceProbabilityModifierData : NMSTemplate
{
	public GcAlienRace Race
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public Single Modifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcNPCRaceProbabilityModifierData(long address) : base(address)
	{

	}
}
