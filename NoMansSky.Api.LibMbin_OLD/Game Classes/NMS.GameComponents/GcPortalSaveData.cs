using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPortalSaveData : NMSTemplate
{
	public GcSeed PortalSeed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public UInt64 LastPortalUA
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Boolean IsStoryPortal
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPortalSaveData(long address) : base(address)
	{

	}
}
