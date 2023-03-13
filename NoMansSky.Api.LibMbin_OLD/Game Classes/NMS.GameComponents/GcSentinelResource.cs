using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelResource : NMSTemplate
{
	public NMSString0x80 Resource
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 BaseHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 HealthIncreasePerLevel
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single RepairTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepairThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSentinelResource(long address) : base(address)
	{

	}
}
