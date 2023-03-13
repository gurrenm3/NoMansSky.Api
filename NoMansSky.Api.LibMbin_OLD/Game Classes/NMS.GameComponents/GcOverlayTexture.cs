using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcOverlayTexture : NMSTemplate
{
	public NMSString0x80 OverlayDiffuse
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 OverlayNormal
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 OverlayMasks
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 OverlayMaskIdx
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcOverlayTexture(long address) : base(address)
	{

	}
}
