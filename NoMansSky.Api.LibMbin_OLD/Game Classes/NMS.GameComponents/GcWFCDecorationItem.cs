using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWFCDecorationItem : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 Group
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single RelativeProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoSceneProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Include
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcWeightedResource> Scenes
	{
		get => cache.GetOrAddValue(new VirtualList<GcWeightedResource>(address + GetOffset()));
		set => TrySetValue<GcWeightedResource>(value);
	}

	public VirtualList<NMSString0x10> ApplicableModules
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean Rotate
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RequireReachable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 MaxPerBuilding
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MinPerBuilding
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean RequireAboveTerrain
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcWFCDecorationItem.InsideOutsideEnum InsideOutside
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWFCDecorationItem.InsideOutsideEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWFCDecorationItem.InsideOutsideEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcWFCDecorationItem.LevelEnum Level
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWFCDecorationItem.LevelEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWFCDecorationItem.LevelEnum>(value);
	}

	public GcWFCDecorationFace Left
	{
		get => GetValue<GcWFCDecorationFace>();
		set => TrySetValue<GcWFCDecorationFace>(value);
	}

	public GcWFCDecorationFace Down
	{
		get => GetValue<GcWFCDecorationFace>();
		set => TrySetValue<GcWFCDecorationFace>(value);
	}

	public GcWFCDecorationFace Back
	{
		get => GetValue<GcWFCDecorationFace>();
		set => TrySetValue<GcWFCDecorationFace>(value);
	}

	public GcWFCDecorationFace Right
	{
		get => GetValue<GcWFCDecorationFace>();
		set => TrySetValue<GcWFCDecorationFace>(value);
	}

	public GcWFCDecorationFace Up
	{
		get => GetValue<GcWFCDecorationFace>();
		set => TrySetValue<GcWFCDecorationFace>(value);
	}

	public GcWFCDecorationFace Forward
	{
		get => GetValue<GcWFCDecorationFace>();
		set => TrySetValue<GcWFCDecorationFace>(value);
	}

	public GcWFCDecorationItem(long address) : base(address)
	{

	}
}
