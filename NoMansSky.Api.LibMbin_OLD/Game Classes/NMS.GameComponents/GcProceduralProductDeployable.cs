using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProceduralProductDeployable : NMSTemplate
{
	public NMSString0x10 BaseID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Variants
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcProceduralProductDeployable(long address) : base(address)
	{

	}
}
