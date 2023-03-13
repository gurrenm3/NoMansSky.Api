using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNameGeneratorSectorTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcNameGeneratorSectorTypes.SectorNameEnum SectorName
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNameGeneratorSectorTypes.SectorNameEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNameGeneratorSectorTypes.SectorNameEnum>(value);
	}

	public GcNameGeneratorSectorTypes(long address) : base(address)
	{

	}
}
