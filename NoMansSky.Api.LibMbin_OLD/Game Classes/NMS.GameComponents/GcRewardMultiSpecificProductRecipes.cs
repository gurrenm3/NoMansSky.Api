using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardMultiSpecificProductRecipes : NMSTemplate
{
	public VirtualList<NMSString0x10> ProductIds
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 DisplayProductId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A SetName
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean Silent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardMultiSpecificProductRecipes(long address) : base(address)
	{

	}
}
