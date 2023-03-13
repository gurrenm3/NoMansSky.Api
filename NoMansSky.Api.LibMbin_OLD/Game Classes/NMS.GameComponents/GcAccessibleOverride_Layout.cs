using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAccessibleOverride_Layout : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcAccessibleOverride_Layout.AccessibleOverride_LayoutEnum AccessibleOverride_Layout
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAccessibleOverride_Layout.AccessibleOverride_LayoutEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAccessibleOverride_Layout.AccessibleOverride_LayoutEnum>(value);
	}

	public Single FloatValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAccessibleOverride_Layout(long address) : base(address)
	{

	}
}
