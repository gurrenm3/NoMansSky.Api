using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCatalogueGroups : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCatalogueGroups.CatalogueGroupEnum CatalogueGroup
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCatalogueGroups.CatalogueGroupEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCatalogueGroups.CatalogueGroupEnum>(value);
	}

	public GcCatalogueGroups(long address) : base(address)
	{

	}
}
