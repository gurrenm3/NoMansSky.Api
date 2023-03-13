using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcObjectPlacementCategory : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcObjectPlacementCategory.ObjectPlacementEnum ObjectPlacement
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcObjectPlacementCategory.ObjectPlacementEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcObjectPlacementCategory.ObjectPlacementEnum>(value);
	}

	public GcObjectPlacementCategory(long address) : base(address)
	{

	}
}
