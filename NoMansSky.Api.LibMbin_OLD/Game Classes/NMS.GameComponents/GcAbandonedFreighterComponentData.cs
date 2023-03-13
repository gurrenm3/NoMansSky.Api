using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAbandonedFreighterComponentData : NMSTemplate
{
	public TkModelResource DungeonRootScene
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public VirtualList<GcFreighterDungeonChoice> DungeonOptions
	{
		get => cache.GetOrAddValue(new VirtualList<GcFreighterDungeonChoice>(address + GetOffset()));
		set => TrySetValue<GcFreighterDungeonChoice>(value);
	}

	public NMSString0x20A MarkerLabel
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public TkTextureResource MarkerIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public GcAbandonedFreighterComponentData(long address) : base(address)
	{

	}
}
