using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPresetTextureData : NMSTemplate
{
	public NMSString0x80 Name
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x100 Filename
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public GcPresetTextureData(long address) : base(address)
	{

	}
}
