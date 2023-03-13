using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAISpaceshipRoles : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcAISpaceshipRoles.AIShipRoleEnum AIShipRole
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAISpaceshipRoles.AIShipRoleEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAISpaceshipRoles.AIShipRoleEnum>(value);
	}

	public GcAISpaceshipRoles(long address) : base(address)
	{

	}
}
