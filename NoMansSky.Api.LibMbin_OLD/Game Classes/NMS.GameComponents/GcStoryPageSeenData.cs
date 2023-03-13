using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStoryPageSeenData : NMSTemplate
{
	public Int32 PageIdx
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LastSeenEntryIdx
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcStoryPageSeenData(long address) : base(address)
	{

	}
}
