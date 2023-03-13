using Reloaded.ModHelper;
using System;
using libMBIN;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkBehaviourTreePriorityDecoratorData : NMSTemplate
{
	public NMSTemplate Child
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public TkBehaviourTreePriorityDecoratorData(long address) : base(address)
	{

	}
}
