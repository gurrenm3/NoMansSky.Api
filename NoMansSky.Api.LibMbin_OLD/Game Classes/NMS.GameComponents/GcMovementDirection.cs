using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMovementDirection : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMovementDirection.MovementDirectionEnum MovementDirection
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMovementDirection.MovementDirectionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMovementDirection.MovementDirectionEnum>(value);
	}

	public GcMovementDirection(long address) : base(address)
	{

	}
}
