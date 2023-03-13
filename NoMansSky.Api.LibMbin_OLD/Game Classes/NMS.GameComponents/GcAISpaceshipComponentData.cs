using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAISpaceshipComponentData : NMSTemplate
{
	public GcAISpaceshipTypes Type
	{
		get => GetValue<GcAISpaceshipTypes>();
		set => TrySetValue<GcAISpaceshipTypes>(value);
	}

	public GcSpaceshipClasses Class
	{
		get => GetValue<GcSpaceshipClasses>();
		set => TrySetValue<GcSpaceshipClasses>(value);
	}

	public GcPrimaryAxis Axis
	{
		get => GetValue<GcPrimaryAxis>();
		set => TrySetValue<GcPrimaryAxis>(value);
	}

	public TkModelResource Hangar
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public Boolean IsSpaceAnomaly
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAISpaceshipComponentData(long address) : base(address)
	{

	}
}
