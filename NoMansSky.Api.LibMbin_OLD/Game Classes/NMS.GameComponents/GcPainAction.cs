using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPainAction : NMSTemplate
{
	public NMSString0x10 Damage
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean RadiusBasedDamage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AffectsPlayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single RetriggerTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPainAction(long address) : base(address)
	{

	}
}
