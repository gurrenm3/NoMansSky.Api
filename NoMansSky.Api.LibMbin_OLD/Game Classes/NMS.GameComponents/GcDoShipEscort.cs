using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDoShipEscort : NMSTemplate
{
	public Boolean MatchRole
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAISpaceshipRoles EscortTargetShipRole
	{
		get => GetValue<GcAISpaceshipRoles>();
		set => TrySetValue<GcAISpaceshipRoles>(value);
	}

	public Boolean MatchFaction
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRealityCommonFactions EscortTargetShipFaction
	{
		get => GetValue<GcRealityCommonFactions>();
		set => TrySetValue<GcRealityCommonFactions>(value);
	}

	public Boolean MatchType
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAISpaceshipTypes EscortTargetShipType
	{
		get => GetValue<GcAISpaceshipTypes>();
		set => TrySetValue<GcAISpaceshipTypes>(value);
	}

	public Single MaxSearchDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDoShipEscort(long address) : base(address)
	{

	}
}
