using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBehaviourDetailAnimsData : NMSTemplate
{
	public TkBlackboardDefaultValueBool CanDetail
	{
		get => GetValue<TkBlackboardDefaultValueBool>();
		set => TrySetValue<TkBlackboardDefaultValueBool>(value);
	}

	public GcBehaviourDetailAnimsData(long address) : base(address)
	{

	}
}
