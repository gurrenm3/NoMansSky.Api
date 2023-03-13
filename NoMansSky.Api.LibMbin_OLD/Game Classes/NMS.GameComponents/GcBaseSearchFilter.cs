using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseSearchFilter : NMSTemplate
{
	public Boolean OnCurrentPlanet
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InCurrentSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsOverlapping
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public UInt64 OnSpecificPlanet
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 InSpecificSystem
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public NMSString0x20A OnSpecificPlanetScanEvent
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcPersistentBaseTypes> MatchingTypes
	{
		get => cache.GetOrAddValue(new VirtualList<GcPersistentBaseTypes>(address + GetOffset()));
		set => TrySetValue<GcPersistentBaseTypes>(value);
	}

	public GcBasePartSearchFilter BasePartFilter
	{
		get => GetValue<GcBasePartSearchFilter>();
		set => TrySetValue<GcBasePartSearchFilter>(value);
	}

	public Int32 ContainsMinParts
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ContainsMaxParts
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcBaseSearchFilter(long address) : base(address)
	{

	}
}
