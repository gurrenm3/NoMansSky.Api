using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInWorldUIScreenData : NMSTemplate
{
	public Single ScreenScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f ScreenOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f ScreenRotation
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcInWorldUIScreenData(long address) : base(address)
	{

	}
}
