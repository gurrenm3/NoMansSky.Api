using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryTechProbability : NMSTemplate
{
	public NMSString0x10 Tech
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcInventoryTechProbability.DesiredTechProbabilityEnum DesiredTechProbability
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcInventoryTechProbability.DesiredTechProbabilityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcInventoryTechProbability.DesiredTechProbabilityEnum>(value);
	}

	public GcInventoryTechProbability(long address) : base(address)
	{

	}
}
