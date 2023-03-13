using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerSpaceshipControlData : NMSTemplate
{
	public GcPlayerSpaceshipEngineData SpaceEngine
	{
		get => GetValue<GcPlayerSpaceshipEngineData>();
		set => TrySetValue<GcPlayerSpaceshipEngineData>(value);
	}

	public GcPlayerSpaceshipEngineData PlanetEngine
	{
		get => GetValue<GcPlayerSpaceshipEngineData>();
		set => TrySetValue<GcPlayerSpaceshipEngineData>(value);
	}

	public GcPlayerSpaceshipEngineData CombatEngine
	{
		get => GetValue<GcPlayerSpaceshipEngineData>();
		set => TrySetValue<GcPlayerSpaceshipEngineData>(value);
	}

	public GcPlayerSpaceshipEngineData AtmosCombatEngine
	{
		get => GetValue<GcPlayerSpaceshipEngineData>();
		set => TrySetValue<GcPlayerSpaceshipEngineData>(value);
	}

	public Single ExitHeightFactorMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExitHeightFactorMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExitHeightFactorPlungeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExitHeightFactorPlungeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExitAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExitAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExitLeaveAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType ExitCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType ExitDownCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single AngularFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTorque
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipPlanetBrakeMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipPlanetBrakeMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipPlanetBrakeMinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipPlanetBrakeMaxHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipPlanetBrakeForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipPlanetBrakeAlignMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipPlanetBrakeAlignMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipMinHeightForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerSpaceshipControlData(long address) : base(address)
	{

	}
}
