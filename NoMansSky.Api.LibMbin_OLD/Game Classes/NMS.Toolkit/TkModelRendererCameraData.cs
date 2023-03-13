using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkModelRendererCameraData : NMSTemplate
{
	public Single Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f Offset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single Roll
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Pitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Rotate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LightPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LightRotate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCameraWanderData Wander
	{
		get => GetValue<TkCameraWanderData>();
		set => TrySetValue<TkCameraWanderData>(value);
	}

	public TkModelRendererCameraData(long address) : base(address)
	{

	}
}
