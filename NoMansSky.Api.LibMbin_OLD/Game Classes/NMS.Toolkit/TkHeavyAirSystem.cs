using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkHeavyAirSystem : NMSTemplate
{
	public NMSString0x80 Material
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
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

	public Vector3f FadeSpeedRange
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

	public Single Colour1Alpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour Colour2
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single Colour2Alpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkHeavyAirSystem(long address) : base(address)
	{

	}
}
