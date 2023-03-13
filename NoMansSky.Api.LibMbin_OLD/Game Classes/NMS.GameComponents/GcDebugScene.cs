using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDebugScene : NMSTemplate
{
	public Boolean Active
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugDraw
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AutoSave
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcExperienceDebugTriggerInput> TriggerActions
	{
		get => cache.GetOrAddValue(new VirtualList<GcExperienceDebugTriggerInput>(address + GetOffset()));
		set => TrySetValue<GcExperienceDebugTriggerInput>(value);
	}

	public Boolean FlyCamSmooth
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single FlyCamSmoothFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlyCamSpeedModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCIdleMinDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCIdleMaxDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<NMSString0x10> DefaultNPCIdles
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcNPCDebugSpawnData> DebugNPCSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCDebugSpawnData>(address + GetOffset()));
		set => TrySetValue<GcNPCDebugSpawnData>(value);
	}

	public Boolean LoadPetsFromDebugScene
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UpdatePetMoods
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ResetMoodsOnSummon
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowAccessoryMoods
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPetBehaviours PetForceBehaviour
	{
		get => GetValue<GcPetBehaviours>();
		set => TrySetValue<GcPetBehaviours>(value);
	}

	public VirtualArray<GcPetData> Pets
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPetData>(address + GetOffset(), 18));
		set => TrySetValue<GcPetData>(value);
	}

	public VirtualArray<GcPetCustomisationData> PetAccessoryCustomisation
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPetCustomisationData>(address + GetOffset(), 18));
		set => TrySetValue<GcPetCustomisationData>(value);
	}

	public Boolean ForcePlayerWalk
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PlayerWalkSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PetRideIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Vector3f> PetRideWayPoints
	{
		get => cache.GetOrAddValue(new VirtualList<Vector3f>(address + GetOffset()));
		set => TrySetValue<Vector3f>(value);
	}

	public Boolean ForceSunPosition
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector3f ForcedSunPosition
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Boolean ControlClouds
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CloudCover
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloudAnimScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f CloudWindOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f CloudStratosphereWindOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Boolean BusyShips
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CustomShipDockedTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipSpawningMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcDebugShipTravelLine> DebugShipPaths
	{
		get => cache.GetOrAddValue(new VirtualList<GcDebugShipTravelLine>(address + GetOffset()));
		set => TrySetValue<GcDebugShipTravelLine>(value);
	}

	public VirtualList<GcDebugCamera> DebugCameraPaths
	{
		get => cache.GetOrAddValue(new VirtualList<GcDebugCamera>(address + GetOffset()));
		set => TrySetValue<GcDebugCamera>(value);
	}

	public VirtualList<GcCreatureDebugSpawnData> DebugCreatureSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureDebugSpawnData>(address + GetOffset()));
		set => TrySetValue<GcCreatureDebugSpawnData>(value);
	}

	public VirtualList<GcMechDebugSpawnData> DebugMechSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcMechDebugSpawnData>(address + GetOffset()));
		set => TrySetValue<GcMechDebugSpawnData>(value);
	}

	public VirtualList<GcAIShipDebugSpawnData> DebugEnemyShipSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipDebugSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipDebugSpawnData>(value);
	}

	public VirtualList<GcAIShipDebugSpawnData> DebugShipSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipDebugSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipDebugSpawnData>(value);
	}

	public VirtualArray<GcCameraFollowSettings> VehicleCameraOverride
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCameraFollowSettings>(address + GetOffset(), 7));
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public Boolean DebugDroneScanPlayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector3f DebugDroneSpawn
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DebugDroneTarget
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Int32 DebugNumDrones
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Vector3f DebugWalkerSpawn
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DebugWalkerTarget
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DebugFlybyTarget
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DebugFlybyDir
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single DebugFlybyRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSeed DebugFlybySeed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public NMSString0x10 DebugExperienceCamShake
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Vector3f DebugShipSpawnPos
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DebugShipSpawnFacing
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DebugShipSpawnUp
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public NMSString0x10 PulseEncounter
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 BackgroundSpaceEncounter
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Vector3f SandwormSpawnPos
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DebugFrigateFlybySpawnPos
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single DebugFrigateFlybyRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DebugFrigateFlybyHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 NormandyReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 LivingFrigateReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single CameraSpinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraSpinRevolutions
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraSpinVerticalOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraSpinDistanceOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType CameraSpinEasing
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public VirtualArray<GcDebugPlanetPos> PlanetPositions
	{
		get => cache.GetOrAddValue(new VirtualArray<GcDebugPlanetPos>(address + GetOffset(), 6));
		set => TrySetValue<GcDebugPlanetPos>(value);
	}

	public GcDebugScene(long address) : base(address)
	{

	}
}
