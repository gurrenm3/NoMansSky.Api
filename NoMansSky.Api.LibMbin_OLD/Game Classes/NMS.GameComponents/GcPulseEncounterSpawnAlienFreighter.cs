using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPulseEncounterSpawnAlienFreighter : NMSTemplate
{
	public NMSString0x20A HailingPuzzleID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcPulseEncounterSpawnAlienFreighter(long address) : base(address)
	{

	}
}
