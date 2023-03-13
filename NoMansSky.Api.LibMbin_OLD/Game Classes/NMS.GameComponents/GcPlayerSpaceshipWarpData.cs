using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerSpaceshipWarpData : NMSTemplate
{
	public Single EntryTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType EntryTunnelCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single TravelTunnelTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType ExitTunnelCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public GcPlayerSpaceshipWarpData(long address) : base(address)
	{

	}
}
