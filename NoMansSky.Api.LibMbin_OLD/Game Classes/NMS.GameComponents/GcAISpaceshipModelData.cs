using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAISpaceshipModelData : NMSTemplate
{
	public NMSString0x80 Filename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcSpaceshipClasses Class
	{
		get => GetValue<GcSpaceshipClasses>();
		set => TrySetValue<GcSpaceshipClasses>(value);
	}

	public GcAISpaceshipRoles AIRole
	{
		get => GetValue<GcAISpaceshipRoles>();
		set => TrySetValue<GcAISpaceshipRoles>(value);
	}

	public GcFrigateClass FrigateClass
	{
		get => GetValue<GcFrigateClass>();
		set => TrySetValue<GcFrigateClass>(value);
	}

	public GcAISpaceshipModelData(long address) : base(address)
	{

	}
}
