using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProjectileImpactData : NMSTemplate
{
	public NMSString0x10 Effect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcProjectileImpactType Impact
	{
		get => GetValue<GcProjectileImpactType>();
		set => TrySetValue<GcProjectileImpactType>(value);
	}

	public libMBIN.NMS.GameComponents.GcProjectileImpactData.ImpactAlignmentEnum ImpactAlignment
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcProjectileImpactData.ImpactAlignmentEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcProjectileImpactData.ImpactAlignmentEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcProjectileImpactData.ImpactAttachmentEnum ImpactAttachment
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcProjectileImpactData.ImpactAttachmentEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcProjectileImpactData.ImpactAttachmentEnum>(value);
	}

	public GcProjectileImpactData(long address) : base(address)
	{

	}
}
