using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSpecificShip : NMSTemplate
{
	public GcResourceElement ShipResource
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public GcInventoryLayout ShipLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcInventoryContainer ShipInventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcSpaceshipClasses ShipType
	{
		get => GetValue<GcSpaceshipClasses>();
		set => TrySetValue<GcSpaceshipClasses>(value);
	}

	public NMSString0x20A NameOverride
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean IsGift
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsRewardShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FormatAsSeasonal
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardSpecificShip(long address) : base(address)
	{

	}
}
