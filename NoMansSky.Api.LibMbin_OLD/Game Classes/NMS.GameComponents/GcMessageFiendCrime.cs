using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMessageFiendCrime : NMSTemplate
{
	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcNodeID Victim
	{
		get => GetValue<GcNodeID>();
		set => TrySetValue<GcNodeID>(value);
	}

	public GcFiendCrime FiendCrimeType
	{
		get => GetValue<GcFiendCrime>();
		set => TrySetValue<GcFiendCrime>(value);
	}

	public Single Value
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMessageFiendCrime(long address) : base(address)
	{

	}
}
