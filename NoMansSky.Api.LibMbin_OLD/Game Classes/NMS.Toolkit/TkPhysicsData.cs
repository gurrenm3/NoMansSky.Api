using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkPhysicsData : NMSTemplate
{
	public Single Mass
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Friction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RollingFriction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AngularDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LinearDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Gravity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkPhysicsData(long address) : base(address)
	{

	}
}
