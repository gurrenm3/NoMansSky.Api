using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInteractionBufferType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcInteractionBufferType.InteractionBufferTypeEnum InteractionBufferType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcInteractionBufferType.InteractionBufferTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcInteractionBufferType.InteractionBufferTypeEnum>(value);
	}

	public GcInteractionBufferType(long address) : base(address)
	{

	}
}
