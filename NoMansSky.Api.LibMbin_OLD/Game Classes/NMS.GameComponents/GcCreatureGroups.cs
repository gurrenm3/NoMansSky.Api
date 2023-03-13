using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureGroups : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureGroups.CreatureGroupEnum CreatureGroup
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureGroups.CreatureGroupEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureGroups.CreatureGroupEnum>(value);
	}

	public GcCreatureGroups(long address) : base(address)
	{

	}
}
