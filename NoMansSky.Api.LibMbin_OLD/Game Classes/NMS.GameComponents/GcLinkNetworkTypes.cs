using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcLinkNetworkTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcLinkNetworkTypes.LinkNetworkTypeEnum LinkNetworkType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcLinkNetworkTypes.LinkNetworkTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcLinkNetworkTypes.LinkNetworkTypeEnum>(value);
	}

	public GcLinkNetworkTypes(long address) : base(address)
	{

	}
}
