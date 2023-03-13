using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAISpaceshipMappingData : NMSTemplate
{
	public VirtualArray<GcAISpaceshipInstanceData> ClassMap
	{
		get => cache.GetOrAddValue(new VirtualArray<GcAISpaceshipInstanceData>(address + GetOffset(), 7));
		set => TrySetValue<GcAISpaceshipInstanceData>(value);
	}

	public GcAISpaceshipMappingData(long address) : base(address)
	{

	}
}
