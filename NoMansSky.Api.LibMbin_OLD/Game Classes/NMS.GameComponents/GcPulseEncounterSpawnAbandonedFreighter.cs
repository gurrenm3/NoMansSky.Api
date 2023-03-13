using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPulseEncounterSpawnAbandonedFreighter : NMSTemplate
{
	public TkModelResource AbandonedFreighter
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public GcPulseEncounterSpawnAbandonedFreighter(long address) : base(address)
	{

	}
}
