using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourPlayAnimData : NMSTemplate
{
	public NMSString0x10 Anim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single BlendInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BlendOutAt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcBehaviourPlayAnimTrigger> Triggers
	{
		get => cache.GetOrAddValue(new VirtualList<GcBehaviourPlayAnimTrigger>(address + GetOffset()));
		set => TrySetValue<GcBehaviourPlayAnimTrigger>(value);
	}

	public GcBehaviourPlayAnimData(long address) : base(address)
	{

	}
}
