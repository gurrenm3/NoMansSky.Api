using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExpeditionHologramComponentData : NMSTemplate
{
	public Single HologramRotationSpeedDegPerSec
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CaptainScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrigateScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f SpawnOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcExpeditionHologramComponentData(long address) : base(address)
	{

	}
}
