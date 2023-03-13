using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSimpleInteractionComponentData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSimpleInteractionComponentData.SimpleInteractionTypeEnum SimpleInteractionType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSimpleInteractionComponentData.SimpleInteractionTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSimpleInteractionComponentData.SimpleInteractionTypeEnum>(value);
	}

	public Single InteractDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Use2dInteractDistance
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRarity Rarity
	{
		get => GetValue<GcRarity>();
		set => TrySetValue<GcRarity>(value);
	}

	public GcSizeIndicator Size
	{
		get => GetValue<GcSizeIndicator>();
		set => TrySetValue<GcSizeIndicator>(value);
	}

	public NMSString0x10 TriggerAction
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 TriggerActionOnPrepare
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 TriggerActionToggle
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean BroadcastTriggerAction
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Delay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean HideContents
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InteractIsCrime
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcFiendCrime InteractFiendCrimeType
	{
		get => GetValue<GcFiendCrime>();
		set => TrySetValue<GcFiendCrime>(value);
	}

	public Single InteractFiendCrimeChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 InteractCrimeLevel
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean NotifyEncounter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcInteractionActivationCost ActivationCost
	{
		get => GetValue<GcInteractionActivationCost>();
		set => TrySetValue<GcInteractionActivationCost>(value);
	}

	public GcStatsEnum StatToTrack
	{
		get => GetValue<GcStatsEnum>();
		set => TrySetValue<GcStatsEnum>(value);
	}

	public Boolean StartsBuried
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MustBeVisibleToInteract
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeedsStorm
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A Name
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A VRInteractMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A TerminalHeading
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A TerminalMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A ScanType
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A ScanData
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcDiscoveryType ScanIcon
	{
		get => GetValue<GcDiscoveryType>();
		set => TrySetValue<GcDiscoveryType>(value);
	}

	public Boolean ActivateLocatorsFromRarity
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<NMSString0x10> RarityLocators
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 3));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcInteractionBaseBuildingState> BaseBuildingTriggerActions
	{
		get => cache.GetOrAddValue(new VirtualList<GcInteractionBaseBuildingState>(address + GetOffset()));
		set => TrySetValue<GcInteractionBaseBuildingState>(value);
	}

	public VirtualList<GcRewardMissionOverride> RewardOverrideTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcRewardMissionOverride>(address + GetOffset()));
		set => TrySetValue<GcRewardMissionOverride>(value);
	}

	public VirtualList<GcPersistencyMissionOverride> PersistencyBufferOverride
	{
		get => cache.GetOrAddValue(new VirtualList<GcPersistencyMissionOverride>(address + GetOffset()));
		set => TrySetValue<GcPersistencyMissionOverride>(value);
	}

	public Boolean UsePersonalPersistentBuffer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ReseedOnRewardSuccess
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CanCollectInMech
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcSimpleInteractionComponentData(long address) : base(address)
	{

	}
}
