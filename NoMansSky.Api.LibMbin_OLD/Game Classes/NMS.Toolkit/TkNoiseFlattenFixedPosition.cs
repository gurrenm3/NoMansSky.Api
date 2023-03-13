using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseFlattenFixedPosition : NMSTemplate
{
	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public TkNoiseFlattenPoint FlattenPoint
	{
		get => GetValue<TkNoiseFlattenPoint>();
		set => TrySetValue<TkNoiseFlattenPoint>(value);
	}

	public TkNoiseFlattenFixedPosition(long address) : base(address)
	{

	}
}
