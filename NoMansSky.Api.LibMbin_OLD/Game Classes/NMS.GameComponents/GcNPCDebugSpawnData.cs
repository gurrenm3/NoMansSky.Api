using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCDebugSpawnData : NMSTemplate
{
	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Facing
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Up
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Boolean FollowWaypoints
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single InitialDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Vector3f> Waypoints
	{
		get => cache.GetOrAddValue(new VirtualList<Vector3f>(address + GetOffset()));
		set => TrySetValue<Vector3f>(value);
	}

	public Boolean PlayIdles
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<NMSString0x10> Idles
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean Run
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RidePet
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAlienRace Race
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public Boolean AddPetAccessories
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PetFollowOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPetData Pet
	{
		get => GetValue<GcPetData>();
		set => TrySetValue<GcPetData>(value);
	}

	public GcPetCustomisationData PetAccessoryCustomisation
	{
		get => GetValue<GcPetCustomisationData>();
		set => TrySetValue<GcPetCustomisationData>(value);
	}

	public GcNPCDebugSpawnData(long address) : base(address)
	{

	}
}
