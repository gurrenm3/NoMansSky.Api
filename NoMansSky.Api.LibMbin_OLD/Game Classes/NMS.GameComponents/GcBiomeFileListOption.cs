using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBiomeFileListOption : NMSTemplate
{
	public GcBiomeSubType SubType
	{
		get => GetValue<GcBiomeSubType>();
		set => TrySetValue<GcBiomeSubType>(value);
	}

	public NMSString0x80 Filename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single Weight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcBiomeFileListOption(long address) : base(address)
	{

	}
}
