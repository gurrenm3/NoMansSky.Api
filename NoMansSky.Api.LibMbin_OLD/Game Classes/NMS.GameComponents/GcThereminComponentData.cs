using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcThereminComponentData : NMSTemplate
{
	public NMSString0x20 VolumeBBName
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single VolumeMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VolumeMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinVolume
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxVolume
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x20 PitchStartLocator
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 PitchEndLocator
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single PitchMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IgnorePlayerDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcThereminComponentData(long address) : base(address)
	{

	}
}
