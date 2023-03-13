using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCharacterRotate : NMSTemplate
{
	public NMSString0x10 Input
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcPrimaryAxis RotateAxis
	{
		get => GetValue<GcPrimaryAxis>();
		set => TrySetValue<GcPrimaryAxis>(value);
	}

	public Single Damping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotateTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCharacterRotate(long address) : base(address)
	{

	}
}
