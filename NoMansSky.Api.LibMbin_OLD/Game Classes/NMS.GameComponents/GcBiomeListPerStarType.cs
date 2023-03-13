using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBiomeListPerStarType : NMSTemplate
{
	public VirtualArray<GcBiomeList> StarType
	{
		get => cache.GetOrAddValue(new VirtualArray<GcBiomeList>(address + GetOffset(), 4));
		set => TrySetValue<GcBiomeList>(value);
	}

	public GcBiomeList LushYellow
	{
		get => GetValue<GcBiomeList>();
		set => TrySetValue<GcBiomeList>(value);
	}

	public GcBiomeList AbandonedYellow
	{
		get => GetValue<GcBiomeList>();
		set => TrySetValue<GcBiomeList>(value);
	}

	public VirtualArray<Single> LifeChance
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> AbandonedLifeChance
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public Single ConvertDeadToWeird
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcBiomeListPerStarType(long address) : base(address)
	{

	}
}
