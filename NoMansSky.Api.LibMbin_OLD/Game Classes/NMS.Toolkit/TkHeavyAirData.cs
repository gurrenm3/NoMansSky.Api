using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkHeavyAirData : NMSTemplate
{
	public NMSString0x80 Material
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 NumberOfParticles
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RadiusY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinParticleLifetime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxParticleLifetime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinVisibleSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedFadeOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxVisibleSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SoftFadeStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnRotationRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f MajorDirection
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f ScaleRange
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f RotationSpeedRange
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f TwinkleRange
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f AmplitudeMin
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f AmplitudeMax
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Colour Colour1
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour Colour2
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public libMBIN.NMS.Toolkit.TkHeavyAirData.EmitterShapeEnum EmitterShape
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkHeavyAirData.EmitterShapeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkHeavyAirData.EmitterShapeEnum>(value);
	}

	public TkHeavyAirData(long address) : base(address)
	{

	}
}
