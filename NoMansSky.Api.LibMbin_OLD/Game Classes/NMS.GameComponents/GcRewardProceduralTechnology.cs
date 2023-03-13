using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardProceduralTechnology : NMSTemplate
{
	public GcProceduralTechnologyCategory Type
	{
		get => GetValue<GcProceduralTechnologyCategory>();
		set => TrySetValue<GcProceduralTechnologyCategory>(value);
	}

	public GcRewardProceduralTechnology(long address) : base(address)
	{

	}
}
