using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExplosionDataTable : NMSTemplate
{
	public NMSString0x80 Name
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<GcExplosionData> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcExplosionData>(address + GetOffset()));
		set => TrySetValue<GcExplosionData>(value);
	}

	public GcExplosionDataTable(long address) : base(address)
	{

	}
}
