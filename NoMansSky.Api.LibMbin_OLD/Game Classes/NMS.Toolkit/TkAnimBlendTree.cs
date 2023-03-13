using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimBlendTree : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSTemplate Tree
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public Int32 Priority
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkAnimationGameData GameData
	{
		get => GetValue<TkAnimationGameData>();
		set => TrySetValue<TkAnimationGameData>(value);
	}

	public TkAnimBlendTree(long address) : base(address)
	{

	}
}
