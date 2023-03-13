using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatDefinition : NMSTemplate
{
	public GcStatType Type
	{
		get => GetValue<GcStatType>();
		set => TrySetValue<GcStatType>(value);
	}

	public GcStatTrackType TrackType
	{
		get => GetValue<GcStatTrackType>();
		set => TrySetValue<GcStatTrackType>(value);
	}

	public GcStatDisplayType DisplayType
	{
		get => GetValue<GcStatDisplayType>();
		set => TrySetValue<GcStatDisplayType>(value);
	}

	public GcStatValueData DefaultValue
	{
		get => GetValue<GcStatValueData>();
		set => TrySetValue<GcStatValueData>(value);
	}

	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean TelemetryUpload
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsProgression
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 MissionMessageDecimals
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcStatDefinition(long address) : base(address)
	{

	}
}
