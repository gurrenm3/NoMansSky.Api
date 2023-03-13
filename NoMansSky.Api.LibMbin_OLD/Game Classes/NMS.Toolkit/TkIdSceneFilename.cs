using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkIdSceneFilename : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x80 Filename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public TkIdSceneFilename(long address) : base(address)
	{

	}
}
