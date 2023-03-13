using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWFCModulePrototype : NMSTemplate
{
	public NMSString0x80 Name
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x80 Group
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single RelativeProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Include
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ExcludeOnGround
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ExcludeOnTop
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Indoors
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LimitToOnePerLevel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ExcludeRotatedVariants
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DontRotateModel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 LayoutGroup
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcWeightedResource> Scenes
	{
		get => cache.GetOrAddValue(new VirtualList<GcWeightedResource>(address + GetOffset()));
		set => TrySetValue<GcWeightedResource>(value);
	}

	public libMBIN.NMS.GameComponents.GcWFCModulePrototype.TerrainEditsEnum TerrainEdits
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWFCModulePrototype.TerrainEditsEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWFCModulePrototype.TerrainEditsEnum>(value);
	}

	public VirtualList<GcWFCTerrainConstraint> TerrainConstraints
	{
		get => cache.GetOrAddValue(new VirtualList<GcWFCTerrainConstraint>(address + GetOffset()));
		set => TrySetValue<GcWFCTerrainConstraint>(value);
	}

	public GcWFCFace Left
	{
		get => GetValue<GcWFCFace>();
		set => TrySetValue<GcWFCFace>(value);
	}

	public GcWFCFace Down
	{
		get => GetValue<GcWFCFace>();
		set => TrySetValue<GcWFCFace>(value);
	}

	public GcWFCFace Back
	{
		get => GetValue<GcWFCFace>();
		set => TrySetValue<GcWFCFace>(value);
	}

	public GcWFCFace Right
	{
		get => GetValue<GcWFCFace>();
		set => TrySetValue<GcWFCFace>(value);
	}

	public GcWFCFace Up
	{
		get => GetValue<GcWFCFace>();
		set => TrySetValue<GcWFCFace>(value);
	}

	public GcWFCFace Forward
	{
		get => GetValue<GcWFCFace>();
		set => TrySetValue<GcWFCFace>(value);
	}

	public libMBIN.NMS.GameComponents.GcWFCModulePrototype.FreighterModuleTypeEnum FreighterModuleType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWFCModulePrototype.FreighterModuleTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWFCModulePrototype.FreighterModuleTypeEnum>(value);
	}

	public GcWFCModulePrototype(long address) : base(address)
	{

	}
}
