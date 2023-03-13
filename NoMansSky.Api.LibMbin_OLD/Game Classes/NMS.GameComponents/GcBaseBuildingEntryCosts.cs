using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingEntryCosts : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Active0AverageFrameTimeCost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Active1AverageFrameTimeCost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ActiveTotalNodes
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ActivePhysicsComponents
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single Inactive0AverageFrameTimeCost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Inactive1AverageFrameTimeCost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 InactiveTotalNodes
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 InactivePhysicsComponents
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcBaseBuildingEntryCosts(long address) : base(address)
	{

	}
}
