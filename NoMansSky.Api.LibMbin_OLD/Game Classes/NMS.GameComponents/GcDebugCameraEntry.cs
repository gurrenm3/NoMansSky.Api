using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDebugCameraEntry : NMSTemplate
{
	public Vector3f Offset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Local
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Facing
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Up
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single FOV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDebugCameraEntry(long address) : base(address)
	{

	}
}
