using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcItemNeedPurpose : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcItemNeedPurpose.ItemPurposeEnum ItemPurpose
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcItemNeedPurpose.ItemPurposeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcItemNeedPurpose.ItemPurposeEnum>(value);
	}

	public GcItemNeedPurpose(long address) : base(address)
	{

	}
}
