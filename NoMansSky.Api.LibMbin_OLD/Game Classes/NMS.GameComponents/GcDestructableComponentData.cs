using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDestructableComponentData : NMSTemplate
{
	public NMSString0x10 Explosion
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single ExplosionScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ExplosionScaleToBounds
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean OnlyExplodeSelf
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 VehicleDestroyEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 TriggerAction
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 IncreaseWanted
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean IncreaseFiendWanted
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single IncreaseFiendWantedChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean NotifyEncounter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 LootReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 LootRewardAmountMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LootRewardAmountMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean CanDestroyFromStoredInteraction
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcSubstanceAmount> GivesSubstances
	{
		get => cache.GetOrAddValue(new VirtualList<GcSubstanceAmount>(address + GetOffset()));
		set => TrySetValue<GcSubstanceAmount>(value);
	}

	public GcStatsEnum StatToTrack
	{
		get => GetValue<GcStatsEnum>();
		set => TrySetValue<GcStatsEnum>(value);
	}

	public NMSString0x10 GivesReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 PirateSystemAltReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean RewardIfDestroyedByOther
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HideReward
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A OverrideRewardLoc
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcRewardMissionOverride> RewardOverrideTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcRewardMissionOverride>(address + GetOffset()));
		set => TrySetValue<GcRewardMissionOverride>(value);
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

	public Boolean UseSystemColorsForTexture
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RemoveModel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HideModel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkModelResource DestroyedModel
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public Boolean DestroyedModelUsesScale
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DestroyedModelCollidesWithEverything
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DestroyForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DestroyForceRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 DestroyEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean DestroyEffectOnSurface
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 DestroyEffectPoint
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single DestroyEffectTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DestroyEffectMatrices
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 AreaDamage
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean ShowInteract
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HideInteractWhenAllArmourDestroyed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ShowInteractRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean GrenadeSingleHit
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcLootProbability> LootItems
	{
		get => cache.GetOrAddValue(new VirtualList<GcLootProbability>(address + GetOffset()));
		set => TrySetValue<GcLootProbability>(value);
	}

	public GcDestructableComponentData(long address) : base(address)
	{

	}
}
