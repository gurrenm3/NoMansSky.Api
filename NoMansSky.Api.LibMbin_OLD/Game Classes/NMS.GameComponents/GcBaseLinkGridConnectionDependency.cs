using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseLinkGridConnectionDependency : NMSTemplate
{
	public GcBaseLinkGridConnectionData Connection
	{
		get => GetValue<GcBaseLinkGridConnectionData>();
		set => TrySetValue<GcBaseLinkGridConnectionData>(value);
	}

	public Int32 DependentRate
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public libMBIN.NMS.GameComponents.GcBaseLinkGridConnectionDependency.DependentEffectEnum DependentEffect
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseLinkGridConnectionDependency.DependentEffectEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseLinkGridConnectionDependency.DependentEffectEnum>(value);
	}

	public Boolean DisableWhenOffline
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TransfersConnections
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBaseLinkGridConnectionDependency(long address) : base(address)
	{

	}
}
