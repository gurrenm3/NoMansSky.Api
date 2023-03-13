using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationCameraData : NMSTemplate
{
	public Int32 InteractionCameraIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20 InteracttionCameraFocusJoint
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single MinPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCustomisationCameraData(long address) : base(address)
	{

	}
}
