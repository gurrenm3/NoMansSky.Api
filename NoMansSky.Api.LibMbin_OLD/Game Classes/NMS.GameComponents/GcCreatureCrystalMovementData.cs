using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureCrystalMovementData : NMSTemplate
{
	public VirtualList<GcCreatureCrystalMovementDataParams> Params
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureCrystalMovementDataParams>(address + GetOffset()));
		set => TrySetValue<GcCreatureCrystalMovementDataParams>(value);
	}

	public GcCreatureCrystalMovementData(long address) : base(address)
	{

	}
}
