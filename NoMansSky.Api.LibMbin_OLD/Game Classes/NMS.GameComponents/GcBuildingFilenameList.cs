using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingFilenameList : NMSTemplate
{
	public VirtualArray<GcBuildingFilename> BuildingFiles
	{
		get => cache.GetOrAddValue(new VirtualArray<GcBuildingFilename>(address + GetOffset(), 52));
		set => TrySetValue<GcBuildingFilename>(value);
	}

	public GcBuildingFilenameList(long address) : base(address)
	{

	}
}
