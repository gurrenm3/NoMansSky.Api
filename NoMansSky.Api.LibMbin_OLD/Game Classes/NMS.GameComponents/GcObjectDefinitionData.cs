using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcObjectDefinitionData : NMSTemplate
{
	public NMSString0x80 Filename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public libMBIN.NMS.GameComponents.GcObjectDefinitionData.ObjectRenderTypeEnum ObjectRenderType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcObjectDefinitionData.ObjectRenderTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcObjectDefinitionData.ObjectRenderTypeEnum>(value);
	}

	public Boolean AutoCollision
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MatchGroundColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcObjectDefinitionData.SizeClassEnum SizeClass
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcObjectDefinitionData.SizeClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcObjectDefinitionData.SizeClassEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcObjectDefinitionData.ObjectCoverageTypeEnum ObjectCoverageType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcObjectDefinitionData.ObjectCoverageTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcObjectDefinitionData.ObjectCoverageTypeEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcObjectDefinitionData.LifeTypeEnum LifeType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcObjectDefinitionData.LifeTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcObjectDefinitionData.LifeTypeEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcObjectDefinitionData.LocationTypeEnum LocationType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcObjectDefinitionData.LocationTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcObjectDefinitionData.LocationTypeEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcObjectDefinitionData.ObjectAlignmentEnum ObjectAlignment
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcObjectDefinitionData.ObjectAlignmentEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcObjectDefinitionData.ObjectAlignmentEnum>(value);
	}

	public GcObjectDefinitionData(long address) : base(address)
	{

	}
}
