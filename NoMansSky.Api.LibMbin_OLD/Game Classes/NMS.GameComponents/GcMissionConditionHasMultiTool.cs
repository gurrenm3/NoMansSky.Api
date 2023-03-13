using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasMultiTool : NMSTemplate
{
	public GcInventoryClass InventoryClass
	{
		get => GetValue<GcInventoryClass>();
		set => TrySetValue<GcInventoryClass>(value);
	}

	public Boolean CheckAllTools
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean BetterClassMatches
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TakeValueFromSeasonData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionHasMultiTool(long address) : base(address)
	{

	}
}
