using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAttachmentPointData : NMSTemplate
{
	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Int32 SimP
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single AttractionStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttractionStartDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAttachmentPointData(long address) : base(address)
	{

	}
}
