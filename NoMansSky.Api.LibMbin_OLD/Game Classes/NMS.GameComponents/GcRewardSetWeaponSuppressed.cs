using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSetWeaponSuppressed : NMSTemplate
{
	public Boolean WeaponSuppressed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardSetWeaponSuppressed(long address) : base(address)
	{

	}
}
