using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkTrophyEnum : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkTrophyEnum.TrophyEnum Trophy
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkTrophyEnum.TrophyEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkTrophyEnum.TrophyEnum>(value);
	}

	public TkTrophyEnum(long address) : base(address)
	{

	}
}
