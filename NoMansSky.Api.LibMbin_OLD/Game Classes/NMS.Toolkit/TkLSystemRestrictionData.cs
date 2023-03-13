using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLSystemRestrictionData : NMSTemplate
{
	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public libMBIN.NMS.Toolkit.TkLSystemRestrictionData.RestrictionEnum Restriction
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkLSystemRestrictionData.RestrictionEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkLSystemRestrictionData.RestrictionEnum>(value);
	}

	public TkLSystemRestrictionData(long address) : base(address)
	{

	}
}
