using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHUDImageData : NMSTemplate
{
	public GcHUDComponent Data
	{
		get => GetValue<GcHUDComponent>();
		set => TrySetValue<GcHUDComponent>(value);
	}

	public NMSString0x80 Image
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcHUDImageData(long address) : base(address)
	{

	}
}
