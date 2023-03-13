using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPersistentBase : NMSTemplate
{
	public Int32 BaseVersion
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 OriginalBaseVersion
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public UInt64 GalacticAddress
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Forward
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public UInt64 UserData
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 LastUpdateTimestamp
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public VirtualList<GcPersistentBaseEntry> Objects
	{
		get => cache.GetOrAddValue(new VirtualList<GcPersistentBaseEntry>(address + GetOffset()));
		set => TrySetValue<GcPersistentBaseEntry>(value);
	}

	public NMSString0x40 RID
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public GcDiscoveryOwner Owner
	{
		get => GetValue<GcDiscoveryOwner>();
		set => TrySetValue<GcDiscoveryOwner>(value);
	}

	public NMSString0x40 Name
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public GcPersistentBaseTypes BaseType
	{
		get => GetValue<GcPersistentBaseTypes>();
		set => TrySetValue<GcPersistentBaseTypes>(value);
	}

	public NMSString0x40 LastEditedById
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public NMSString0x40 LastEditedByUsername
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public Vector3f ScreenshotAt
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f ScreenshotPos
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcGameMode GameMode
	{
		get => GetValue<GcGameMode>();
		set => TrySetValue<GcGameMode>(value);
	}

	public GcPersistentBaseDifficultyData Difficulty
	{
		get => GetValue<GcPersistentBaseDifficultyData>();
		set => TrySetValue<GcPersistentBaseDifficultyData>(value);
	}

	public NMSString0x20 PlatformToken
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Boolean IsReported
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsFeatured
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBaseAutoPowerSetting AutoPowerSetting
	{
		get => GetValue<GcBaseAutoPowerSetting>();
		set => TrySetValue<GcBaseAutoPowerSetting>(value);
	}

	public GcPersistentBase(long address) : base(address)
	{

	}
}
