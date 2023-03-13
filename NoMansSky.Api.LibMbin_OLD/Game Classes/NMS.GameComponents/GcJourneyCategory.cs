using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcJourneyCategory : NMSTemplate
{
	public GcJourneyCategoryType Type
	{
		get => GetValue<GcJourneyCategoryType>();
		set => TrySetValue<GcJourneyCategoryType>(value);
	}

	public GcGameMode GameModeRestriction
	{
		get => GetValue<GcGameMode>();
		set => TrySetValue<GcGameMode>(value);
	}

	public GcMissionFaction Faction
	{
		get => GetValue<GcMissionFaction>();
		set => TrySetValue<GcMissionFaction>(value);
	}

	public NMSString0x20A NameIDLower
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A NameIDUpper
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A DescriptionID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public TkTextureResource IconOn
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource IconOff
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualList<GcJourneyMedal> Medals
	{
		get => cache.GetOrAddValue(new VirtualList<GcJourneyMedal>(address + GetOffset()));
		set => TrySetValue<GcJourneyMedal>(value);
	}

	public GcJourneyCategory(long address) : base(address)
	{

	}
}
