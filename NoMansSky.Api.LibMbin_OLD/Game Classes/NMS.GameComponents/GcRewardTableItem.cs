using Reloaded.ModHelper;
using System;
using libMBIN;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardTableItem : NMSTemplate
{
	public Single PercentageChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSTemplate Reward
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public NMSString0x40 LabelID
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public GcRewardTableItem(long address) : base(address)
	{

	}
}
