using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingFamily : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcBaseBuildingFamily.FamilyTypeEnum FamilyType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseBuildingFamily.FamilyTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseBuildingFamily.FamilyTypeEnum>(value);
	}

	public VirtualList<NMSString0x10> ObjectIDs
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcBaseBuildingFamily(long address) : base(address)
	{

	}
}
