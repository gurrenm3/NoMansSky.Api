using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourApplyDamageData : NMSTemplate
{
	public TkBlackboardDefaultValueId PlayerDamageType
	{
		get => GetValue<TkBlackboardDefaultValueId>();
		set => TrySetValue<TkBlackboardDefaultValueId>(value);
	}

	public TkBlackboardDefaultValueFloat Radius
	{
		get => GetValue<TkBlackboardDefaultValueFloat>();
		set => TrySetValue<TkBlackboardDefaultValueFloat>(value);
	}

	public TkBlackboardDefaultValueVector Offset
	{
		get => GetValue<TkBlackboardDefaultValueVector>();
		set => TrySetValue<TkBlackboardDefaultValueVector>(value);
	}

	public GcBehaviourApplyDamageData(long address) : base(address)
	{

	}
}
