using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPhysicsCollisionGroups : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPhysicsCollisionGroups.CollisionGroupEnum CollisionGroup
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPhysicsCollisionGroups.CollisionGroupEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPhysicsCollisionGroups.CollisionGroupEnum>(value);
	}

	public GcPhysicsCollisionGroups(long address) : base(address)
	{

	}
}
