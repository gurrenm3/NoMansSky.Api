using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBiomeCloudSettings : NMSTemplate
{
	public Single MinCover
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxCover
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinRateOfChange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRateOfChange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinRatio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRatio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TendencyTowardsBeingCloudy
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour StormCloudTopColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour StormCloudBottomColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcBiomeCloudSettings(long address) : base(address)
	{

	}
}
