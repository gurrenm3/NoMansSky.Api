using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCNavigationAreaComponentData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcNPCNavigationAreaComponentData.NavAreaTypeEnum NavAreaType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNPCNavigationAreaComponentData.NavAreaTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNPCNavigationAreaComponentData.NavAreaTypeEnum>(value);
	}

	public Single MinRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SphereCastHeightClearance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NeighbourCandidateDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxNeighbourSlope
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ConnectionLengthFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcNPCNavigationAreaComponentData(long address) : base(address)
	{

	}
}
