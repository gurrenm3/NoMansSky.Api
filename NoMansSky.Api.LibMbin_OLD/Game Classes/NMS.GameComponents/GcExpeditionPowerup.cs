using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExpeditionPowerup : NMSTemplate
{
	public NMSString0x10 ProductId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcFrigateStatType StatModified
	{
		get => GetValue<GcFrigateStatType>();
		set => TrySetValue<GcFrigateStatType>(value);
	}

	public Int32 ValueChange
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20A SelectionDescription
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A ModuleDescription
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcExpeditionPowerup(long address) : base(address)
	{

	}
}
