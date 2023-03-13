using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatLevelData : NMSTemplate
{
	public NMSString0x20A LevelName
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A LevelNameUpper
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A OSDLevelName
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcStatValueData Value
	{
		get => GetValue<GcStatValueData>();
		set => TrySetValue<GcStatValueData>(value);
	}

	public NMSString0x10 TrophyToUnlock
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcStatLevelData(long address) : base(address)
	{

	}
}
