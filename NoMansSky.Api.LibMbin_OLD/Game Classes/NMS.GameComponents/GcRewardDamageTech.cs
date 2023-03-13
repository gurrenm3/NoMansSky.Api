using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardDamageTech : NMSTemplate
{
	public GcTechnologyCategory Category
	{
		get => GetValue<GcTechnologyCategory>();
		set => TrySetValue<GcTechnologyCategory>(value);
	}

	public NMSString0x10 TechToDamage_optional
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean ShowDamageMessage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardDamageTech(long address) : base(address)
	{

	}
}
