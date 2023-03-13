using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingModeCondition : NMSTemplate
{
	public VirtualArray<Int32> ValidBuildingModes
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 5));
		set => TrySetValue<Int32>(value);
	}

	public GcBuildingModeCondition(long address) : base(address)
	{

	}
}
