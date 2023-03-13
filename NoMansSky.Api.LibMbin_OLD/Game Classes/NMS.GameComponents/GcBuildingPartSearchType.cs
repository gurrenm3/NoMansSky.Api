using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingPartSearchType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBuildingPartSearchType.BuildPartSearchTypeEnum BuildPartSearchType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBuildingPartSearchType.BuildPartSearchTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBuildingPartSearchType.BuildPartSearchTypeEnum>(value);
	}

	public VirtualList<GcPersistentBaseTypes> BaseSearchFilters
	{
		get => cache.GetOrAddValue(new VirtualList<GcPersistentBaseTypes>(address + GetOffset()));
		set => TrySetValue<GcPersistentBaseTypes>(value);
	}

	public Boolean IncludeOnlyOverlappingBases
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IncludeGlobalBaseObjects
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBuildingPartSearchType(long address) : base(address)
	{

	}
}
