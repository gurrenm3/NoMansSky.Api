using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBirdData : NMSTemplate
{
	public Single FlapSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlapSpeedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlapSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlapAccel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlapTurn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlapSpeedMinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlapSpeedMaxScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlapSpeedForMinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlapSpeedForMaxScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 CircleAttractor
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcBirdData(long address) : base(address)
	{

	}
}
