using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcLeveledStatData : NMSTemplate
{
	public NMSString0x10 StatId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A StatTitle
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public libMBIN.NMS.GameComponents.GcLeveledStatData.StatMessageTypeEnum StatMessageType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcLeveledStatData.StatMessageTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcLeveledStatData.StatMessageTypeEnum>(value);
	}

	public NMSString0x20A NotifyMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A NotifyMessageSingular
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean ShowInTerminal
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowStatLevel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkTextureResource Icon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<GcStatLevelData> StatLevels
	{
		get => cache.GetOrAddValue(new VirtualArray<GcStatLevelData>(address + GetOffset(), 11));
		set => TrySetValue<GcStatLevelData>(value);
	}

	public Boolean UseRankNotStats
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TelemetryUpload
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcLeveledStatData(long address) : base(address)
	{

	}
}
