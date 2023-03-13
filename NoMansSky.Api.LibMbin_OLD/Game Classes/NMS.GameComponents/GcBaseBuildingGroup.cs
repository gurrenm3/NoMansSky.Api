using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingGroup : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A Name
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public TkTextureResource Icon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public Int32 DefaultColourIdx
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcBaseBuildingSubGroup> SubGroups
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingSubGroup>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingSubGroup>(value);
	}

	public GcBaseBuildingGroup(long address) : base(address)
	{

	}
}
