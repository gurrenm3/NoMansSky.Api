using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSeasonalStage : NMSTemplate
{
	public VirtualList<GcSeasonalMilestone> Milestones
	{
		get => cache.GetOrAddValue(new VirtualList<GcSeasonalMilestone>(address + GetOffset()));
		set => TrySetValue<GcSeasonalMilestone>(value);
	}

	public TkTextureResource Icon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public NMSString0x20A Title
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A Description
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcSeasonalStage(long address) : base(address)
	{

	}
}
