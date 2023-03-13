using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimPoseCorrelationData : NMSTemplate
{
	public NMSString0x10 ItemA
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 ItemB
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Correlation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkAnimPoseCorrelationData(long address) : base(address)
	{

	}
}
