using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDiscoveryType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDiscoveryType.DiscoveryTypeEnum DiscoveryType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDiscoveryType.DiscoveryTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDiscoveryType.DiscoveryTypeEnum>(value);
	}

	public GcDiscoveryType(long address) : base(address)
	{

	}
}
