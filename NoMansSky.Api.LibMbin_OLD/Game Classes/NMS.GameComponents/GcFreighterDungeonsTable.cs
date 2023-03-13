using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFreighterDungeonsTable : NMSTemplate
{
	public VirtualList<GcFreighterDungeonParams> Dungeons
	{
		get => cache.GetOrAddValue(new VirtualList<GcFreighterDungeonParams>(address + GetOffset()));
		set => TrySetValue<GcFreighterDungeonParams>(value);
	}

	public GcFreighterDungeonsTable(long address) : base(address)
	{

	}
}
