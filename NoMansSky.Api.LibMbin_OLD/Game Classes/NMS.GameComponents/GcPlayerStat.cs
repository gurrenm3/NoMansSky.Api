using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerStat : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcStatValueData Value
	{
		get => GetValue<GcStatValueData>();
		set => TrySetValue<GcStatValueData>(value);
	}

	public GcPlayerStat(long address) : base(address)
	{

	}
}
