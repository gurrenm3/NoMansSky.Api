using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSelectableObjectSpawnList : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcSelectableObjectSpawnData> Objects
	{
		get => cache.GetOrAddValue(new VirtualList<GcSelectableObjectSpawnData>(address + GetOffset()));
		set => TrySetValue<GcSelectableObjectSpawnData>(value);
	}

	public GcSelectableObjectSpawnList(long address) : base(address)
	{

	}
}
