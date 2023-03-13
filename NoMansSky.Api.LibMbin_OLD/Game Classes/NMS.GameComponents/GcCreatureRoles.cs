using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureRoles : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureRoles.CreatureRoleEnum CreatureRole
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureRoles.CreatureRoleEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureRoles.CreatureRoleEnum>(value);
	}

	public GcCreatureRoles(long address) : base(address)
	{

	}
}
