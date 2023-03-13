using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcLookAtComponentData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcLookAtComponentData.LookAtTypeEnum LookAtType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcLookAtComponentData.LookAtTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcLookAtComponentData.LookAtTypeEnum>(value);
	}

	public NMSString0x20 NodeName
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single RotationRateFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinRotationRateDegrees
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcLookAtComponentData(long address) : base(address)
	{

	}
}
