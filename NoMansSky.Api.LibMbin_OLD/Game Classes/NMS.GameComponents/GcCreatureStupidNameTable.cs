using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureStupidNameTable : NMSTemplate
{
	public NMSString0x80 StupidUserName
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<GcCreatureStupidName> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureStupidName>(address + GetOffset()));
		set => TrySetValue<GcCreatureStupidName>(value);
	}

	public GcCreatureStupidNameTable(long address) : base(address)
	{

	}
}
