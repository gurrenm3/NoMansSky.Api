using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkDynamicChainComponentData : NMSTemplate
{
	public Single AngularLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TwistLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MotorStrengthCone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MotorStrengthTwist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxMotorForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Gravity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AirThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VertAirThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WindStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LinearDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AngularDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InitialBodyMass
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BodyMassChange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean WeightByJointLength
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<NMSString0x20> IgnoreJoints
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public TkDynamicChainComponentData(long address) : base(address)
	{

	}
}
