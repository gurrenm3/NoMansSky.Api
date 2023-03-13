using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPhotoFauna : NMSTemplate
{
	public Int32 AmountMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AmountMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcPhotoCreature CreatureArea
	{
		get => GetValue<GcPhotoCreature>();
		set => TrySetValue<GcPhotoCreature>(value);
	}

	public Boolean MustBePet
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPhotoFauna(long address) : base(address)
	{

	}
}
