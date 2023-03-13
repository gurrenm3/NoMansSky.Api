using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcByteBeatToken : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcByteBeatToken.ByteBeatTokenEnum ByteBeatToken
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcByteBeatToken.ByteBeatTokenEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcByteBeatToken.ByteBeatTokenEnum>(value);
	}

	public GcByteBeatToken(long address) : base(address)
	{

	}
}
