using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionPulseEncounterActive : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionPulseEncounterActive.TestEncounterTypeEnum TestEncounterType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionPulseEncounterActive.TestEncounterTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionPulseEncounterActive.TestEncounterTypeEnum>(value);
	}

	public NMSString0x10 SpecificObjectID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean RequireFullySpawned
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionPulseEncounterActive(long address) : base(address)
	{

	}
}
