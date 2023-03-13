using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWealthClass : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcWealthClass.WealthClassEnum WealthClass
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWealthClass.WealthClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWealthClass.WealthClassEnum>(value);
	}

	public GcWealthClass(long address) : base(address)
	{

	}
}
