using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasShip : NMSTemplate
{
	public GcSpaceshipClasses ShipType
	{
		get => GetValue<GcSpaceshipClasses>();
		set => TrySetValue<GcSpaceshipClasses>(value);
	}

	public GcInventoryClass ShipInventoryClass
	{
		get => GetValue<GcInventoryClass>();
		set => TrySetValue<GcInventoryClass>(value);
	}

	public Boolean CheckAllShips
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean BetterClassMatches
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DontCheckType
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TakeValueFromSeasonData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionHasShip(long address) : base(address)
	{

	}
}
