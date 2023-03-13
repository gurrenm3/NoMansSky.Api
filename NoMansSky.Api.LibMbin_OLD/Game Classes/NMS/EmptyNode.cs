using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class EmptyNode : NMSTemplate
{
	public VirtualArray<Byte> Padding
	{
		get => cache.GetOrAddValue(new VirtualArray<Byte>(address + GetOffset(), 0));
		set => TrySetValue<Byte>(value);
	}

	public EmptyNode(long address) : base(address)
	{

	}
}
