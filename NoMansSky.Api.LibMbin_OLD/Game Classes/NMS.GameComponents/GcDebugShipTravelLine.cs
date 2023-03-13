using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDebugShipTravelLine : NMSTemplate
{
	public Vector3f Origin
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Dir
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single Length
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InfluenceRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDebugShipTravelLine(long address) : base(address)
	{

	}
}
