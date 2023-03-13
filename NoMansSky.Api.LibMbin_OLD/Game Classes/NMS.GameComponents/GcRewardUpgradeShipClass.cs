using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardUpgradeShipClass : NMSTemplate
{
	public Boolean Silent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcInventoryClass ForceToSpecificClass
	{
		get => GetValue<GcInventoryClass>();
		set => TrySetValue<GcInventoryClass>(value);
	}

	public Boolean MatchClassToCommunityTier
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardUpgradeShipClass(long address) : base(address)
	{

	}
}
