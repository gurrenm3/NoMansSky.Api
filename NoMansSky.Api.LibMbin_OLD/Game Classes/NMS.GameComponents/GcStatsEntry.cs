using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatsEntry : NMSTemplate
{
	public GcStatsTypes Type
	{
		get => GetValue<GcStatsTypes>();
		set => TrySetValue<GcStatsTypes>(value);
	}

	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single RangeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RangeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean LessIsBetter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 BaseTechID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcStatsEntry(long address) : base(address)
	{

	}
}
