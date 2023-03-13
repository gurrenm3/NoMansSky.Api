using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateStatType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcFrigateStatType.FrigateStatTypeEnum FrigateStatType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcFrigateStatType.FrigateStatTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcFrigateStatType.FrigateStatTypeEnum>(value);
	}

	public GcFrigateStatType(long address) : base(address)
	{

	}
}
