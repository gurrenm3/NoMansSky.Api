using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerExperienceSpawnData : NMSTemplate
{
	public NMSString0x10 Archetype
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 AppearAnim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 SpawnLocator
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A SpawnLocatorScanEvent
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlayerExperienceSpawnData.FaceDirEnum FaceDir
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerExperienceSpawnData.FaceDirEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerExperienceSpawnData.FaceDirEnum>(value);
	}

	public Single MinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Int32> MinNum
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 7));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> MaxNum
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 7));
		set => TrySetValue<Int32>(value);
	}

	public Single ActiveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerExperienceSpawnData(long address) : base(address)
	{

	}
}
