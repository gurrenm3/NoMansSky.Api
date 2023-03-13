using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureHarvestSubstanceList : NMSTemplate
{
	public NMSString0x10 CreatureType
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 Item
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x80 Desc
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 MinBlobs
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCreatureHarvestSubstanceList(long address) : base(address)
	{

	}
}
