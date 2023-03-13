using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourLaunchProjectileData : NMSTemplate
{
	public TkBlackboardDefaultValueId Projectile
	{
		get => GetValue<TkBlackboardDefaultValueId>();
		set => TrySetValue<TkBlackboardDefaultValueId>(value);
	}

	public NMSString0x40 LaunchJoint
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single HorizontalDispersion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VerticalDispersion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcBehaviourLaunchProjectileData(long address) : base(address)
	{

	}
}
