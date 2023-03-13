using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkVolumeTriggerType : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkVolumeTriggerType.VolumeTriggerTypeEnum VolumeTriggerType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkVolumeTriggerType.VolumeTriggerTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkVolumeTriggerType.VolumeTriggerTypeEnum>(value);
	}

	public TkVolumeTriggerType(long address) : base(address)
	{

	}
}
