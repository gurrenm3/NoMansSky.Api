using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseLinkGridData : NMSTemplate
{
	public GcBaseLinkGridConnectionData Connection
	{
		get => GetValue<GcBaseLinkGridConnectionData>();
		set => TrySetValue<GcBaseLinkGridConnectionData>(value);
	}

	public Int32 Rate
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Storage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public libMBIN.NMS.GameComponents.GcBaseLinkGridData.DependsOnEnvironmentEnum DependsOnEnvironment
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseLinkGridData.DependsOnEnvironmentEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseLinkGridData.DependsOnEnvironmentEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcBaseLinkGridData.DependsOnHotspotsEnum DependsOnHotspots
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseLinkGridData.DependsOnHotspotsEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseLinkGridData.DependsOnHotspotsEnum>(value);
	}

	public VirtualList<GcBaseLinkGridConnectionDependency> DependentConnections
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseLinkGridConnectionDependency>(address + GetOffset()));
		set => TrySetValue<GcBaseLinkGridConnectionDependency>(value);
	}

	public GcBaseLinkGridData(long address) : base(address)
	{

	}
}
