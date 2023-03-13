using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultyOptionUIGroup : NMSTemplate
{
	public NMSString0x20A HeadingLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcDifficultySettingUIOption> DifficultyOptions
	{
		get => cache.GetOrAddValue(new VirtualList<GcDifficultySettingUIOption>(address + GetOffset()));
		set => TrySetValue<GcDifficultySettingUIOption>(value);
	}

	public GcDifficultyOptionUIGroup(long address) : base(address)
	{

	}
}
