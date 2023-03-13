using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHand : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcHand.HandEnum Hand
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcHand.HandEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcHand.HandEnum>(value);
	}

	public GcHand(long address) : base(address)
	{

	}
}
