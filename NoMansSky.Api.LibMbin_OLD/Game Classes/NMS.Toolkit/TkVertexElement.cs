using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkVertexElement : NMSTemplate
{
	public Int32 SemanticID
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Size
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Type
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Offset
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Normalise
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public libMBIN.NMS.Toolkit.TkVertexElement.InstancingEnum Instancing
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkVertexElement.InstancingEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkVertexElement.InstancingEnum>(value);
	}

	public Int64 PlatformData
	{
		get => GetValue<Int64>();
		set => TrySetValue<Int64>(value);
	}

	public TkVertexElement(long address) : base(address)
	{

	}
}
