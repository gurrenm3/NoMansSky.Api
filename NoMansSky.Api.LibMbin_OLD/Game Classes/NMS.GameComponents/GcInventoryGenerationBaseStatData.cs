using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryGenerationBaseStatData : NMSTemplate
{
	public VirtualArray<GcInventoryGenerationBaseStatClassData> BaseStatsPerClass
	{
		get => cache.GetOrAddValue(new VirtualArray<GcInventoryGenerationBaseStatClassData>(address + GetOffset(), 4));
		set => TrySetValue<GcInventoryGenerationBaseStatClassData>(value);
	}

	public GcInventoryGenerationBaseStatData(long address) : base(address)
	{

	}
}
