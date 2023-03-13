using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraShakeAction : NMSTemplate
{
	public NMSString0x10 Shake
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single FalloffMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FalloffMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCameraShakeAction(long address) : base(address)
	{

	}
}
