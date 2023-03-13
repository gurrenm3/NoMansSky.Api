using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcModBasePart : NMSTemplate
{
	public NMSString0x40 ID
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public GcProductData ProductData
	{
		get => GetValue<GcProductData>();
		set => TrySetValue<GcProductData>(value);
	}

	public GcBaseBuildingEntry PartData
	{
		get => GetValue<GcBaseBuildingEntry>();
		set => TrySetValue<GcBaseBuildingEntry>(value);
	}

	public GcModBasePart(long address) : base(address)
	{

	}
}
