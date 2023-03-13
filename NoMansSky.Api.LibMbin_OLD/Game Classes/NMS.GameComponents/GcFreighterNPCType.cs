using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFreighterNPCType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcFreighterNPCType.FreighterNPCTypeEnum FreighterNPCType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcFreighterNPCType.FreighterNPCTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcFreighterNPCType.FreighterNPCTypeEnum>(value);
	}

	public GcFreighterNPCType(long address) : base(address)
	{

	}
}
