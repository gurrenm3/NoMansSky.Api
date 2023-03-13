using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryLayoutGenerationDataEntry : NMSTemplate
{
	public Int32 MinSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MinTechSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxTechSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MinCargoSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxCargoSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcInventoryLayoutGenerationBounds Bounds
	{
		get => GetValue<GcInventoryLayoutGenerationBounds>();
		set => TrySetValue<GcInventoryLayoutGenerationBounds>(value);
	}

	public GcInventoryLayoutGenerationBounds TechBounds
	{
		get => GetValue<GcInventoryLayoutGenerationBounds>();
		set => TrySetValue<GcInventoryLayoutGenerationBounds>(value);
	}

	public Int32 MaxNumSpecialTechSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcInventoryIndex SpecialTechSlotMaxIndex
	{
		get => GetValue<GcInventoryIndex>();
		set => TrySetValue<GcInventoryIndex>(value);
	}

	public GcInventoryLayoutGenerationDataEntry(long address) : base(address)
	{

	}
}
