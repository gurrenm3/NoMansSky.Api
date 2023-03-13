using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcEncounterType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcEncounterType.EncounterTypeEnum EncounterType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcEncounterType.EncounterTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcEncounterType.EncounterTypeEnum>(value);
	}

	public GcEncounterType(long address) : base(address)
	{

	}
}
