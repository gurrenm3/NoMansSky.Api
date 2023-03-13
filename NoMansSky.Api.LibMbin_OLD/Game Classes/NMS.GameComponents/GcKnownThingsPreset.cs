using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcKnownThingsPreset : NMSTemplate
{
	public VirtualList<NMSString0x10> KnownTech
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> KnownProducts
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> KnownSpecials
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x20A> KnownRefinerRecipes
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcWordKnowledge> KnownWords
	{
		get => cache.GetOrAddValue(new VirtualList<GcWordKnowledge>(address + GetOffset()));
		set => TrySetValue<GcWordKnowledge>(value);
	}

	public VirtualList<GcWordGroupKnowledge> KnownWordGroups
	{
		get => cache.GetOrAddValue(new VirtualList<GcWordGroupKnowledge>(address + GetOffset()));
		set => TrySetValue<GcWordGroupKnowledge>(value);
	}

	public GcKnownThingsPreset(long address) : base(address)
	{

	}
}
