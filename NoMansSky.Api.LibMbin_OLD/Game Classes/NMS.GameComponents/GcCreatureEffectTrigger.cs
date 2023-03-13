using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureEffectTrigger : NMSTemplate
{
	public NMSString0x10 Effect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x100> JointName
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x100>(address + GetOffset()));
		set => TrySetValue<NMSString0x100>(value);
	}

	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 Anim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Frame
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean GroundTint
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCreatureEffectTrigger(long address) : base(address)
	{

	}
}
