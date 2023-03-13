using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureAudioTable : NMSTemplate
{
	public VirtualList<GcCreatureVocalSoundData> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureVocalSoundData>(address + GetOffset()));
		set => TrySetValue<GcCreatureVocalSoundData>(value);
	}

	public GcCreatureAudioTable(long address) : base(address)
	{

	}
}
