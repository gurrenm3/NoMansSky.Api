using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCComponentData : NMSTemplate
{
	public GcAlienRace Race
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public NMSString0x10 HologramEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean IsOldStyleNPC
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsMech
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcCharacterAlternateAnimation> AlternateAnims
	{
		get => cache.GetOrAddValue(new VirtualList<GcCharacterAlternateAnimation>(address + GetOffset()));
		set => TrySetValue<GcCharacterAlternateAnimation>(value);
	}

	public VirtualList<NMSString0x10> Tags
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcNPCComponentData(long address) : base(address)
	{

	}
}
