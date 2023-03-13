using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMultitoolPoolData : NMSTemplate
{
	public NMSString0x80 File
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 MinDraw
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxDraw
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PoolProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PoolIsSecret
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMultitoolPoolData(long address) : base(address)
	{

	}
}
