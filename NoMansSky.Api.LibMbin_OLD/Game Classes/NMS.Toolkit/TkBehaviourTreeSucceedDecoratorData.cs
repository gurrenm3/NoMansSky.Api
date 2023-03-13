using Reloaded.ModHelper;
using System;
using libMBIN;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkBehaviourTreeSucceedDecoratorData : NMSTemplate
{
	public NMSTemplate Child
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public TkBehaviourTreeSucceedDecoratorData(long address) : base(address)
	{

	}
}
