using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionBasePartsQuery : NMSTemplate
{
	public GcBasePartSearchFilter PartsSearchFilter
	{
		get => GetValue<GcBasePartSearchFilter>();
		set => TrySetValue<GcBasePartSearchFilter>(value);
	}

	public Int32 MinPartsFound
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxPartsFound
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcBaseSearchFilter ExcludeBasesFilter
	{
		get => GetValue<GcBaseSearchFilter>();
		set => TrySetValue<GcBaseSearchFilter>(value);
	}

	public Boolean ExcludeGlobalBuffer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SearchDistanceLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMissionConditionBasePartsQuery(long address) : base(address)
	{

	}
}
