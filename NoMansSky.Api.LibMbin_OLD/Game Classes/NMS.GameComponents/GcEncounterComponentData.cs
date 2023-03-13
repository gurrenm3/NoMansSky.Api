using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcEncounterComponentData : NMSTemplate
{
	public GcEncounterType EncounterType
	{
		get => GetValue<GcEncounterType>();
		set => TrySetValue<GcEncounterType>(value);
	}

	public VirtualList<NMSString0x10> InteractMissionTable
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcEncounterComponentData(long address) : base(address)
	{

	}
}
