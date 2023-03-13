using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSquadronPilotData : NMSTemplate
{
	public GcResourceElement NPCResource
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public GcResourceElement ShipResource
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public UInt64 TraitsSeed
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt16 PilotRank
	{
		get => GetValue<UInt16>();
		set => TrySetValue<UInt16>(value);
	}

	public GcSquadronPilotData(long address) : base(address)
	{

	}
}
