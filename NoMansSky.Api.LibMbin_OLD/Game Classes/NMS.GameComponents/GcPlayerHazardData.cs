using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerHazardData : NMSTemplate
{
	public Single ProtectionInitialTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f ProtectionTime
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f DamageRate
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f WoundRate
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single RechargeInitialTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RechargeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 Damage
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean Increases
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkCurveType DisplayCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single TriggerValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CapValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CriticalValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutputMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutputMinAddition
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutputMaxAddition
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerHazardData(long address) : base(address)
	{

	}
}
