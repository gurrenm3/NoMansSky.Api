using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCSeatedPosture : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcNPCSeatedPosture.NPCSeatedPostureEnum NPCSeatedPosture
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNPCSeatedPosture.NPCSeatedPostureEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNPCSeatedPosture.NPCSeatedPostureEnum>(value);
	}

	public GcNPCSeatedPosture(long address) : base(address)
	{

	}
}
