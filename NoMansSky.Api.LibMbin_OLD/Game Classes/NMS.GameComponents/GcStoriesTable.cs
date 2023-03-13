using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStoriesTable : NMSTemplate
{
	public VirtualArray<GcStoryCategory> Table
	{
		get => cache.GetOrAddValue(new VirtualArray<GcStoryCategory>(address + GetOffset(), 8));
		set => TrySetValue<GcStoryCategory>(value);
	}

	public GcStoriesTable(long address) : base(address)
	{

	}
}
