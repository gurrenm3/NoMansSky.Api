using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNGuiEditorGraphicType : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkNGuiEditorGraphicType.NGuiEditorGraphicEnum NGuiEditorGraphic
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNGuiEditorGraphicType.NGuiEditorGraphicEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNGuiEditorGraphicType.NGuiEditorGraphicEnum>(value);
	}

	public TkNGuiEditorGraphicType(long address) : base(address)
	{

	}
}
