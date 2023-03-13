using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInteractionActivationCost : NMSTemplate
{
	public NMSString0x10 SubstanceId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> AltIds
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Cost
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean Repeat
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 RequiredTech
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<Int32> OnlyChargeDuringSeasons
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public GcInteractionActivationCost(long address) : base(address)
	{

	}
}
