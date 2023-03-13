using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNGuiAlignment : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkNGuiAlignment.VerticalEnum Vertical
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNGuiAlignment.VerticalEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNGuiAlignment.VerticalEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkNGuiAlignment.HorizontalEnum Horizontal
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNGuiAlignment.HorizontalEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNGuiAlignment.HorizontalEnum>(value);
	}

	public TkNGuiAlignment(long address) : base(address)
	{

	}
}
