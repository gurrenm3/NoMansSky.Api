using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAtlasGlobals : NMSTemplate
{
	public Int32 ChanceOfDisconnect
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TimeoutSecNameResolution
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TimeoutSecConnection
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TimeoutSecSendRecv
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcAtlasGlobals(long address) : base(address)
	{

	}
}
