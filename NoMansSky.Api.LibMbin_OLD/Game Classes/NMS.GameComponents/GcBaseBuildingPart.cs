using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingPart : NMSTemplate
{
	public NMSString0x20A ID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcBaseBuildingPartStyleModel> StyleModels
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingPartStyleModel>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingPartStyleModel>(value);
	}

	public GcBaseBuildingPart(long address) : base(address)
	{

	}
}
