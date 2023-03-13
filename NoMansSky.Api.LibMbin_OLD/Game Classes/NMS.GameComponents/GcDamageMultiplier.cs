using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDamageMultiplier : NMSTemplate
{
	public GcDamageType Type
	{
		get => GetValue<GcDamageType>();
		set => TrySetValue<GcDamageType>(value);
	}

	public Single Multiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDamageMultiplier(long address) : base(address)
	{

	}
}
