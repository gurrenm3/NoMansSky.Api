using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcStatType.StatTypeEnum StatType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcStatType.StatTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcStatType.StatTypeEnum>(value);
	}

	public GcStatType(long address) : base(address)
	{

	}
}
