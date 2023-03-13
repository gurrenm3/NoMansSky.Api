using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScanEventData : NMSTemplate
{
	public NMSString0x20A Name
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A ForceInteraction
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcInteractionType ForceInteractionType
	{
		get => GetValue<GcInteractionType>();
		set => TrySetValue<GcInteractionType>(value);
	}

	public GcAlienRace RequireInteractionRace
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public Boolean ForceBroken
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceFixed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceOverridesAll
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 ForceOverrideEncounter
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean IsCommunityPortalOverride
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ClearForcedInteractionOnCompletion
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BuildingPreventionRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AlwaysShow
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeverShow
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A PlanetLabelText
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single SurveyDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x20A SurveyDiscoveryOSDMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public libMBIN.NMS.GameComponents.GcScanEventData.EventStartTypeEnum EventStartType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScanEventData.EventStartTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScanEventData.EventStartTypeEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcScanEventData.EventEndTypeEnum EventEndType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScanEventData.EventEndTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScanEventData.EventEndTypeEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcScanEventData.EventPriorityEnum EventPriority
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScanEventData.EventPriorityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScanEventData.EventPriorityEnum>(value);
	}

	public Boolean CanEndFromOutsideMission
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableMultiplayerSync
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ReplaceEventIfAlreadyActive
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcScanEventData.BuildingLocationEnum BuildingLocation
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScanEventData.BuildingLocationEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScanEventData.BuildingLocationEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcScanEventData.BuildingTypeEnum BuildingType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScanEventData.BuildingTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScanEventData.BuildingTypeEnum>(value);
	}

	public GcBuildingClassification BuildingClass
	{
		get => GetValue<GcBuildingClassification>();
		set => TrySetValue<GcBuildingClassification>(value);
	}

	public Boolean AllowFriendsBases
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceWideRandom
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MustFindSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowOverriddenBuildings
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcScanEventData.SolarSystemLocationEnum SolarSystemLocation
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScanEventData.SolarSystemLocationEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScanEventData.SolarSystemLocationEnum>(value);
	}

	public GcScanEventSolarSystemLookup SolarSystemAttributes
	{
		get => GetValue<GcScanEventSolarSystemLookup>();
		set => TrySetValue<GcScanEventSolarSystemLookup>(value);
	}

	public GcScanEventSolarSystemLookup SolarSystemAttributesFallback
	{
		get => GetValue<GcScanEventSolarSystemLookup>();
		set => TrySetValue<GcScanEventSolarSystemLookup>(value);
	}

	public Boolean ForceRestartInteraction
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 HasReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A NextOption
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcScanEventTriggers TriggerActions
	{
		get => GetValue<GcScanEventTriggers>();
		set => TrySetValue<GcScanEventTriggers>(value);
	}

	public VirtualList<NMSString0x100> UAsList
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x100>(address + GetOffset()));
		set => TrySetValue<NMSString0x100>(value);
	}

	public GcTechnologyCategory TechShopType
	{
		get => GetValue<GcTechnologyCategory>();
		set => TrySetValue<GcTechnologyCategory>(value);
	}

	public NMSString0x20 OSDMessage
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 InterstellarOSDMessage
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 MarkerLabel
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public TkTextureResource MarkerIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride
	{
		get => GetValue<GcScannerIconHighlightTypes>();
		set => TrySetValue<GcScannerIconHighlightTypes>(value);
	}

	public Single StartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MessageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MessageDisplayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAudioWwiseEvents MessageAudio
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public Single IconTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TooltipTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean TooltipRepeats
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowEndTooltip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20 TooltipMessage
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public GcResourceElement ResourceOverride
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public GcScanEventData(long address) : base(address)
	{

	}
}
