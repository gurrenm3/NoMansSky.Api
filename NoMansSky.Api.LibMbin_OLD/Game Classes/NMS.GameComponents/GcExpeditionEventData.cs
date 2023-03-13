using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExpeditionEventData : NMSTemplate
{
	public NMSString0x20A ID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Single> StatContribution
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public Int32 DifficultyModifier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 DifficultyVarianceModifier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AdditionalShipDifficultyIncrease
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 EasySuccessReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 WhaleReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
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

	public GcNumberedTextList SuccessDescriptionList
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList SuccessWhaleDescriptionList
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList FailureDescriptionList
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList GenericSuccessDescriptionList
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList GenericFailureDescriptionList
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList GenericFailureWhaleDescriptionList
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList DamageDescriptionList
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList SecondaryDescriptionList
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList SecondaryFailureDescriptionList
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcNumberedTextList SecondaryDamageDescriptionList
	{
		get => GetValue<GcNumberedTextList>();
		set => TrySetValue<GcNumberedTextList>(value);
	}

	public GcExpeditionEventData(long address) : base(address)
	{

	}
}
