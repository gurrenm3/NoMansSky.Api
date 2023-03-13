using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWFCTerrainConstraint : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcWFCTerrainConstraint.DirectionEnum Direction
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWFCTerrainConstraint.DirectionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWFCTerrainConstraint.DirectionEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcWFCTerrainConstraint.LevelsEnum Levels
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWFCTerrainConstraint.LevelsEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWFCTerrainConstraint.LevelsEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcWFCTerrainConstraint.TerrainEnum Terrain
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWFCTerrainConstraint.TerrainEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWFCTerrainConstraint.TerrainEnum>(value);
	}

	public GcWFCTerrainConstraint(long address) : base(address)
	{

	}
}
