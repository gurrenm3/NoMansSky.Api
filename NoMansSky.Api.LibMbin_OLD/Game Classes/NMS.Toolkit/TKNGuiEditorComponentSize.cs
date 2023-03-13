using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TKNGuiEditorComponentSize : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TKNGuiEditorComponentSize.NGuiEditorComponentSizeEnum NGuiEditorComponentSize
	{
		get => GetValue<libMBIN.NMS.Toolkit.TKNGuiEditorComponentSize.NGuiEditorComponentSizeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TKNGuiEditorComponentSize.NGuiEditorComponentSizeEnum>(value);
	}

	public TKNGuiEditorComponentSize(long address) : base(address)
	{

	}
}
