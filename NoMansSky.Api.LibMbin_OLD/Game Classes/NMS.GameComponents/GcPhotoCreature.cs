using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPhotoCreature : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPhotoCreature.PhotoCreatureTypeEnum PhotoCreatureType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPhotoCreature.PhotoCreatureTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPhotoCreature.PhotoCreatureTypeEnum>(value);
	}

	public GcPhotoCreature(long address) : base(address)
	{

	}
}
