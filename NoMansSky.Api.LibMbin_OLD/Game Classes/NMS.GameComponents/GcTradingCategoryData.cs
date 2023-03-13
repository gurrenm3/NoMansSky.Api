using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTradingCategoryData : NMSTemplate
{
	public NMSString0x40 Name
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public TkTextureResource Icon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public Single ProductMultiplierChangePer100
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SubstanceMultiplierChangePer100
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcTradingCategoryData(long address) : base(address)
	{

	}
}
