using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TKNGuiEditorTextType : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TKNGuiEditorTextType.NGuiEditorTextEnum NGuiEditorText
	{
		get => GetValue<libMBIN.NMS.Toolkit.TKNGuiEditorTextType.NGuiEditorTextEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TKNGuiEditorTextType.NGuiEditorTextEnum>(value);
	}

	public TKNGuiEditorTextType(long address) : base(address)
	{

	}
}
