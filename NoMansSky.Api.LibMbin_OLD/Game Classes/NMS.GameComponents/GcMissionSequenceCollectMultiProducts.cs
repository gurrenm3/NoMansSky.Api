using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceCollectMultiProducts : NMSTemplate
{
	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<GcProductToCollect> Products
	{
		get => cache.GetOrAddValue(new VirtualList<GcProductToCollect>(address + GetOffset()));
		set => TrySetValue<GcProductToCollect>(value);
	}

	public Boolean WaitForSelected
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SearchCookingIngredients
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceCollectMultiProducts(long address) : base(address)
	{

	}
}
