using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNGuiForcedStyle : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkNGuiForcedStyle.NGuiForcedStyleEnum NGuiForcedStyle
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNGuiForcedStyle.NGuiForcedStyleEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNGuiForcedStyle.NGuiForcedStyleEnum>(value);
	}

	public TkNGuiForcedStyle(long address) : base(address)
	{

	}
}
