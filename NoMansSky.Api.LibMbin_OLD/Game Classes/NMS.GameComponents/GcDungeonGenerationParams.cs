using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDungeonGenerationParams : NMSTemplate
{
	public UInt32 SizeX
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt32 SizeY
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt32 SizeZ
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt32 EntranceX
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt32 EntranceY
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt32 EntranceZ
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public UInt32 Rooms
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public Single XProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single YProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ZProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StraightMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcDungeonRoomParams> MainRoomTypes
	{
		get => cache.GetOrAddValue(new VirtualList<GcDungeonRoomParams>(address + GetOffset()));
		set => TrySetValue<GcDungeonRoomParams>(value);
	}

	public VirtualList<NMSString0x10> BranchRoomTypes
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcDungeonQuestParams> Quests
	{
		get => cache.GetOrAddValue(new VirtualList<GcDungeonQuestParams>(address + GetOffset()));
		set => TrySetValue<GcDungeonQuestParams>(value);
	}

	public VirtualList<NMSTemplate> GenerationRules
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public VirtualList<NMSString0x10> PruningRules
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcDungeonGenerationParams(long address) : base(address)
	{

	}
}
