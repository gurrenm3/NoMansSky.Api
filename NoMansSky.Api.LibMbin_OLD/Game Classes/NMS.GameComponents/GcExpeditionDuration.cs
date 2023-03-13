using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExpeditionDuration : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcExpeditionDuration.ExpeditionDurationEnum ExpeditionDuration
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcExpeditionDuration.ExpeditionDurationEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcExpeditionDuration.ExpeditionDurationEnum>(value);
	}

	public GcExpeditionDuration(long address) : base(address)
	{

	}
}
