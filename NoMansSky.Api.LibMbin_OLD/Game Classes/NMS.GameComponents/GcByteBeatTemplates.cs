using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcByteBeatTemplates : NMSTemplate
{
	public VirtualList<NMSString0x40> InitialTrees
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x40>(address + GetOffset()));
		set => TrySetValue<NMSString0x40>(value);
	}

	public VirtualList<GcByteBeatTemplate> Templates
	{
		get => cache.GetOrAddValue(new VirtualList<GcByteBeatTemplate>(address + GetOffset()));
		set => TrySetValue<GcByteBeatTemplate>(value);
	}

	public VirtualArray<Single> CombinerWeights
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 18));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcByteBeatDrum> KickDrums
	{
		get => cache.GetOrAddValue(new VirtualList<GcByteBeatDrum>(address + GetOffset()));
		set => TrySetValue<GcByteBeatDrum>(value);
	}

	public VirtualList<GcByteBeatDrum> SnareDrums
	{
		get => cache.GetOrAddValue(new VirtualList<GcByteBeatDrum>(address + GetOffset()));
		set => TrySetValue<GcByteBeatDrum>(value);
	}

	public VirtualList<GcByteBeatDrum> HiHats
	{
		get => cache.GetOrAddValue(new VirtualList<GcByteBeatDrum>(address + GetOffset()));
		set => TrySetValue<GcByteBeatDrum>(value);
	}

	public Single OperatorPermuteChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TemplateCombineChanceAtRoot
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TemplateCombineChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcByteBeatSong> Songs
	{
		get => cache.GetOrAddValue(new VirtualList<GcByteBeatSong>(address + GetOffset()));
		set => TrySetValue<GcByteBeatSong>(value);
	}

	public GcByteBeatTemplates(long address) : base(address)
	{

	}
}
