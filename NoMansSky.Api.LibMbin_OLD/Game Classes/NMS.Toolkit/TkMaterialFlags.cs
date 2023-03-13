using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkMaterialFlags : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkMaterialFlags.MaterialFlagEnum MaterialFlag
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkMaterialFlags.MaterialFlagEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkMaterialFlags.MaterialFlagEnum>(value);
	}

	public TkMaterialFlags(long address) : base(address)
	{

	}
}
