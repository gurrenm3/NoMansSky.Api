using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureInfo : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureInfo.AgeEnum Age
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureInfo.AgeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureInfo.AgeEnum>(value);
	}

	public NMSString0x80 Gender1
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 Gender2
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 Temperament
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 Diet
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 Weight1
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 Height1
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 Weight2
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 Height2
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single Weight1_float
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Height1_float
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Weight2_float
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Height2_float
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 Notes
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcRarity Rarity
	{
		get => GetValue<GcRarity>();
		set => TrySetValue<GcRarity>(value);
	}

	public NMSString0x20A BiomeDesc
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A TempermentDesc
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A DietDesc
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A NotesDesc
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcCreatureInfo(long address) : base(address)
	{

	}
}
