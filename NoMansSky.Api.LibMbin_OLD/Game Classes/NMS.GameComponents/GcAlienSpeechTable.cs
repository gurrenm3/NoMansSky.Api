using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAlienSpeechTable : NMSTemplate
{
	public VirtualList<GcAlienSpeechEntry> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcAlienSpeechEntry>(address + GetOffset()));
		set => TrySetValue<GcAlienSpeechEntry>(value);
	}

	public GcAlienSpeechTable(long address) : base(address)
	{

	}
}
