using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatsGroup : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkTextureResource Icon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualList<GcStatsEntry> StatIds
	{
		get => cache.GetOrAddValue(new VirtualList<GcStatsEntry>(address + GetOffset()));
		set => TrySetValue<GcStatsEntry>(value);
	}

	public GcStatsGroup(long address) : base(address)
	{

	}
}
