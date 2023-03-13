using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateFlybyLayout : NMSTemplate
{
	public GcFrigateFlybyType FlybyType
	{
		get => GetValue<GcFrigateFlybyType>();
		set => TrySetValue<GcFrigateFlybyType>(value);
	}

	public Single InitialSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InterestTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InterestDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcFrigateFlybyOption> Frigates
	{
		get => cache.GetOrAddValue(new VirtualList<GcFrigateFlybyOption>(address + GetOffset()));
		set => TrySetValue<GcFrigateFlybyOption>(value);
	}

	public GcFrigateFlybyLayout(long address) : base(address)
	{

	}
}
