using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureTypes.CreatureTypeEnum CreatureType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureTypes.CreatureTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureTypes.CreatureTypeEnum>(value);
	}

	public GcCreatureTypes(long address) : base(address)
	{

	}
}
