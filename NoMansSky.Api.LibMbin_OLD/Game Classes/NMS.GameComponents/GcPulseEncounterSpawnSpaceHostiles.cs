using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPulseEncounterSpawnSpaceHostiles : NMSTemplate
{
	public GcResourceElement CustomShipResource
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public Int32 NumberOfShips
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 AttackDefinition
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcPulseEncounterSpawnSpaceHostiles(long address) : base(address)
	{

	}
}
