using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceVisitPlanets : NMSTemplate
{
	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<GcBiomeType> PlanetTypesToWatch
	{
		get => cache.GetOrAddValue(new VirtualList<GcBiomeType>(address + GetOffset()));
		set => TrySetValue<GcBiomeType>(value);
	}

	public Boolean MustAlsoDiscover
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 NumberOfEachToDiscover
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean TakeNumberFromSeasonalData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceVisitPlanets(long address) : base(address)
	{

	}
}
