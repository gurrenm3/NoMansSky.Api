using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureIkType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureIkType.CreatureIkTypeEnum CreatureIkType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureIkType.CreatureIkTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureIkType.CreatureIkTypeEnum>(value);
	}

	public GcCreatureIkType(long address) : base(address)
	{

	}
}
