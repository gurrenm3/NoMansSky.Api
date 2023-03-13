using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatsEnum : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcStatsEnum.StatEnumEnum StatEnum
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcStatsEnum.StatEnumEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcStatsEnum.StatEnumEnum>(value);
	}

	public GcStatsEnum(long address) : base(address)
	{

	}
}
