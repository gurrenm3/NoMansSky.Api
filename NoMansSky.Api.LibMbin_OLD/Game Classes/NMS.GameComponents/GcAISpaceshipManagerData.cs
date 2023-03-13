using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAISpaceshipManagerData : NMSTemplate
{
	public VirtualArray<GcAISpaceshipModelDataArray> SystemSpaceships
	{
		get => cache.GetOrAddValue(new VirtualArray<GcAISpaceshipModelDataArray>(address + GetOffset(), 5));
		set => TrySetValue<GcAISpaceshipModelDataArray>(value);
	}

	public GcAISpaceshipManagerData(long address) : base(address)
	{

	}
}
