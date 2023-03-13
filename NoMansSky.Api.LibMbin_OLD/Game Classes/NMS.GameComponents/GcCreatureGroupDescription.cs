using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureGroupDescription : NMSTemplate
{
	public NMSString0x10 Group
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 MinGroupSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxGroupSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single GroupsPerSquareKm
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureGroupDescription(long address) : base(address)
	{

	}
}
