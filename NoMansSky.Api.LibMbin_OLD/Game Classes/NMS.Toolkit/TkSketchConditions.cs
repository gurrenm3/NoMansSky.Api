using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkSketchConditions : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkSketchConditions.ConditionEnum Condition
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkSketchConditions.ConditionEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkSketchConditions.ConditionEnum>(value);
	}

	public TkSketchConditions(long address) : base(address)
	{

	}
}
