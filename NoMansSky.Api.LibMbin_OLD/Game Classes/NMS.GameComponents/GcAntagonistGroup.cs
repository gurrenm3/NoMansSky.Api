using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAntagonistGroup : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcAntagonistGroup.AntagonistGroupEnum AntagonistGroup
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAntagonistGroup.AntagonistGroupEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAntagonistGroup.AntagonistGroupEnum>(value);
	}

	public GcAntagonistGroup(long address) : base(address)
	{

	}
}
