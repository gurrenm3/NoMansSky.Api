using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGeneratedBaseLockDoorPair : NMSTemplate
{
	public NMSString0x10 Door
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 Lock
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcGeneratedBaseLockDoorPair(long address) : base(address)
	{

	}
}
