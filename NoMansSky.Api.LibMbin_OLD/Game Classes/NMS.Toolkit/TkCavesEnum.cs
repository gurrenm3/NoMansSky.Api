using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkCavesEnum : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkCavesEnum.CaveTypesEnum CaveTypes
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkCavesEnum.CaveTypesEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkCavesEnum.CaveTypesEnum>(value);
	}

	public TkCavesEnum(long address) : base(address)
	{

	}
}
