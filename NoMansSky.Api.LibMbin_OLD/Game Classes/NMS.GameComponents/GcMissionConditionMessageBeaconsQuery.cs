using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionMessageBeaconsQuery : NMSTemplate
{
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

	public Single SearchDistanceLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMissionConditionMessageBeaconsQuery(long address) : base(address)
	{

	}
}
