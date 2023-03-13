using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateClass : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcFrigateClass.FrigateClassEnum FrigateClass
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcFrigateClass.FrigateClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcFrigateClass.FrigateClassEnum>(value);
	}

	public GcFrigateClass(long address) : base(address)
	{

	}
}
