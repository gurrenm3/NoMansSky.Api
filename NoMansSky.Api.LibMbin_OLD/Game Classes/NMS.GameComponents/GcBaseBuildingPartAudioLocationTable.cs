using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingPartAudioLocationTable : NMSTemplate
{
	public VirtualList<GcBaseBuildingPartAudioLocationEntry> AudioLocations
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingPartAudioLocationEntry>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingPartAudioLocationEntry>(value);
	}

	public GcBaseBuildingPartAudioLocationTable(long address) : base(address)
	{

	}
}
