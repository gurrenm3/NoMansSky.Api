using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasProcProduct : NMSTemplate
{
	public GcProceduralProductCategory ProcProduct
	{
		get => GetValue<GcProceduralProductCategory>();
		set => TrySetValue<GcProceduralProductCategory>(value);
	}

	public Boolean ForceSearchFreighterAndChests
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SearchEveryShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionHasProcProduct(long address) : base(address)
	{

	}
}
