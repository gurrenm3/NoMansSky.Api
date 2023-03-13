using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcModelExplosionRule : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcModelExplosionRule.MatchNodeTypeEnum MatchNodeType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcModelExplosionRule.MatchNodeTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcModelExplosionRule.MatchNodeTypeEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcModelExplosionRule.MatchNameEnum MatchName
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcModelExplosionRule.MatchNameEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcModelExplosionRule.MatchNameEnum>(value);
	}

	public NMSString0x20 String
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public libMBIN.NMS.GameComponents.GcModelExplosionRule.ExplodeActionEnum ExplodeAction
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcModelExplosionRule.ExplodeActionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcModelExplosionRule.ExplodeActionEnum>(value);
	}

	public Vector3f AxisMultiplier
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Offset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single ExplodeMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcModelExplosionRule(long address) : base(address)
	{

	}
}
