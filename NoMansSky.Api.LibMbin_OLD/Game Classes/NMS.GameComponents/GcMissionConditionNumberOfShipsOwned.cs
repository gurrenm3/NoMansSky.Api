using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionNumberOfShipsOwned : NMSTemplate
{
	public Int32 NumShips
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkEqualityEnum Test
	{
		get => GetValue<TkEqualityEnum>();
		set => TrySetValue<TkEqualityEnum>(value);
	}

	public GcMissionConditionNumberOfShipsOwned(long address) : base(address)
	{

	}
}
