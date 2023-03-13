using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkRotationComponentData : NMSTemplate
{
	public Single Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f Axis
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Boolean AlwaysUpdate
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 SyncGroup
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkRotationComponentData(long address) : base(address)
	{

	}
}
