using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSimpleIkRecoilComponentData : NMSTemplate
{
	public NMSString0x100 EndJoint
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Single HitReactDirectedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitReactDirectedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitReactRandomMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitReactRandomMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AngleLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinHitReactTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RecoverTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ActiveRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSimpleIkRecoilComponentData(long address) : base(address)
	{

	}
}
