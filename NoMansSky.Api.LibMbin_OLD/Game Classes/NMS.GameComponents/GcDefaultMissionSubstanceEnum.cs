using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDefaultMissionSubstanceEnum : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDefaultMissionSubstanceEnum.DefaultSubstanceTypeEnum DefaultSubstanceType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDefaultMissionSubstanceEnum.DefaultSubstanceTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDefaultMissionSubstanceEnum.DefaultSubstanceTypeEnum>(value);
	}

	public GcDefaultMissionSubstanceEnum(long address) : base(address)
	{

	}
}
