using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelSpawnData : NMSTemplate
{
	public GcSentinelTypes Type
	{
		get => GetValue<GcSentinelTypes>();
		set => TrySetValue<GcSentinelTypes>(value);
	}

	public Int32 MinAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcSentinelSpawnData(long address) : base(address)
	{

	}
}
