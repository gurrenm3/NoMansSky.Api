using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateFlybyOption : NMSTemplate
{
	public GcFrigateClass FrigateClass
	{
		get => GetValue<GcFrigateClass>();
		set => TrySetValue<GcFrigateClass>(value);
	}

	public Int32 MinCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single Weight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcFrigateFlybyOption(long address) : base(address)
	{

	}
}
