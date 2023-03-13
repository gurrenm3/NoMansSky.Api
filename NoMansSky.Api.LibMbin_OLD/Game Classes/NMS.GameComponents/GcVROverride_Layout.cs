using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVROverride_Layout : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcVROverride_Layout.VROverride_LayoutEnum VROverride_Layout
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcVROverride_Layout.VROverride_LayoutEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcVROverride_Layout.VROverride_LayoutEnum>(value);
	}

	public Single FloatValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcVROverride_Layout(long address) : base(address)
	{

	}
}
