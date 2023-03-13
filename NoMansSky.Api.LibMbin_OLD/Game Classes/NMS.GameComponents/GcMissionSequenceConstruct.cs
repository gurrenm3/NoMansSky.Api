using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceConstruct : NMSTemplate
{
	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 NumUniquePartsRequired
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcConstructionPart> PotentialParts
	{
		get => cache.GetOrAddValue(new VirtualList<GcConstructionPart>(address + GetOffset()));
		set => TrySetValue<GcConstructionPart>(value);
	}

	public GcBuildingPartSearchType Type
	{
		get => GetValue<GcBuildingPartSearchType>();
		set => TrySetValue<GcBuildingPartSearchType>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceConstruct(long address) : base(address)
	{

	}
}
