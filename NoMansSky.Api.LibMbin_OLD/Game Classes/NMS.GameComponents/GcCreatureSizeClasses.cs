using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureSizeClasses : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureSizeClasses.CreatureSizeClassEnum CreatureSizeClass
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureSizeClasses.CreatureSizeClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureSizeClasses.CreatureSizeClassEnum>(value);
	}

	public GcCreatureSizeClasses(long address) : base(address)
	{

	}
}
