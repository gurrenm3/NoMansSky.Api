using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryLayoutGenerationData : NMSTemplate
{
	public VirtualArray<GcInventoryLayoutGenerationDataEntry> GenerationDataPerSizeType
	{
		get => cache.GetOrAddValue(new VirtualArray<GcInventoryLayoutGenerationDataEntry>(address + GetOffset(), 37));
		set => TrySetValue<GcInventoryLayoutGenerationDataEntry>(value);
	}

	public GcInventoryLayoutGenerationData(long address) : base(address)
	{

	}
}
