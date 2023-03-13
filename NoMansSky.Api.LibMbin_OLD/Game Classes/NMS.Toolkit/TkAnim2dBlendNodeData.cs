using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnim2dBlendNodeData : NMSTemplate
{
	public Vector2f Position
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public NMSTemplate BlendChild
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public TkAnim2dBlendNodeData(long address) : base(address)
	{

	}
}
