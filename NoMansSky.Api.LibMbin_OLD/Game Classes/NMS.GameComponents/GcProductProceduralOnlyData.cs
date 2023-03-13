using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProductProceduralOnlyData : NMSTemplate
{
	public Int32 DropWeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 BaseValueMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 BaseValueMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AgeMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AgeMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcNameGeneratorWord Description
	{
		get => GetValue<GcNameGeneratorWord>();
		set => TrySetValue<GcNameGeneratorWord>(value);
	}

	public TkTextureResource Icon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource HeroIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public GcProductProceduralOnlyData(long address) : base(address)
	{

	}
}
