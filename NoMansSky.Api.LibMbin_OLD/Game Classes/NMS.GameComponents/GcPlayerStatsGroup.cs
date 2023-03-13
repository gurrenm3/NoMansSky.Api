using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerStatsGroup : NMSTemplate
{
	public NMSString0x10 GroupId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public UInt64 Address
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public VirtualList<GcPlayerStat> Stats
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerStat>(address + GetOffset()));
		set => TrySetValue<GcPlayerStat>(value);
	}

	public GcPlayerStatsGroup(long address) : base(address)
	{

	}
}
