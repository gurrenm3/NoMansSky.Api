using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionBaseQuery : NMSTemplate
{
	public GcBaseSearchFilter BaseSearchFilter
	{
		get => GetValue<GcBaseSearchFilter>();
		set => TrySetValue<GcBaseSearchFilter>(value);
	}

	public Int32 MinBasesFound
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxBasesFound
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SearchDistanceLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean TakeSpecificPartIdFromSeasonData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionBaseQuery(long address) : base(address)
	{

	}
}
