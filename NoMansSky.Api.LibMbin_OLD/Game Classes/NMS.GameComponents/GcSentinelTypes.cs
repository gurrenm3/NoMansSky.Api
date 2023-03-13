using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSentinelTypes.SentinelTypeEnum SentinelType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSentinelTypes.SentinelTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSentinelTypes.SentinelTypeEnum>(value);
	}

	public GcSentinelTypes(long address) : base(address)
	{

	}
}
