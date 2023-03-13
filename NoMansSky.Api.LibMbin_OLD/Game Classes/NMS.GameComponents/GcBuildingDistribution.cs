using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingDistribution : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 MinDistance
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxDistance
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcBuildingDistribution(long address) : base(address)
	{

	}
}
