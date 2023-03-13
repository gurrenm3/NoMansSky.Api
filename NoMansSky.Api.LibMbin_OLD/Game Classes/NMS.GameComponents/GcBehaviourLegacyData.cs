using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourLegacyData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBehaviourLegacyData.LegacyBehaviourEnum LegacyBehaviour
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBehaviourLegacyData.LegacyBehaviourEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBehaviourLegacyData.LegacyBehaviourEnum>(value);
	}

	public GcBehaviourLegacyData(long address) : base(address)
	{

	}
}
