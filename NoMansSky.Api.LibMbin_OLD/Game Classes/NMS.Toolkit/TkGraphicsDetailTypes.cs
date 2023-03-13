using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkGraphicsDetailTypes : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkGraphicsDetailTypes.GraphicDetailEnum GraphicDetail
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailTypes.GraphicDetailEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailTypes.GraphicDetailEnum>(value);
	}

	public TkGraphicsDetailTypes(long address) : base(address)
	{

	}
}
