using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExpeditionEventOccurrenceRate : NMSTemplate
{
	public VirtualArray<GcExpeditionCategoryStrength> ExpeditionCategory
	{
		get => cache.GetOrAddValue(new VirtualArray<GcExpeditionCategoryStrength>(address + GetOffset(), 5));
		set => TrySetValue<GcExpeditionCategoryStrength>(value);
	}

	public GcExpeditionEventOccurrenceRate(long address) : base(address)
	{

	}
}
