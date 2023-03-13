using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExpeditionInterventionEventData : NMSTemplate
{
	public NMSString0x20A ID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Int32 SelectionWeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcExpeditionCategory ExpeditionCategory
	{
		get => GetValue<GcExpeditionCategory>();
		set => TrySetValue<GcExpeditionCategory>(value);
	}

	public GcNumberedTextList InteractionID
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public NMSString0x20 SuccessLogEntry
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 AvoidanceLogEntry
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 FailureLogEntry
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x10 SuccessReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 FailureReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 FailureDamageChance
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcExpeditionInterventionEventData(long address) : base(address)
	{

	}
}
