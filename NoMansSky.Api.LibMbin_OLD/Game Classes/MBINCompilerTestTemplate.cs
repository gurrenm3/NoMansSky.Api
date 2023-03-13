using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class MBINCompilerTestTemplate : NMSTemplate
{
	public Boolean TestBoolTrue
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TestBoolFalse
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TestBool3
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int16 TestInt16
	{
		get => GetValue<Int16>();
		set => TrySetValue<Int16>(value);
	}

	public Int32 TestInt32
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int64 TestInt64
	{
		get => GetValue<Int64>();
		set => TrySetValue<Int64>(value);
	}

	public Single TestFloat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 TestEnumYes
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TestEnumNo
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public string TestString
	{
		get => GetValue<String>();
		set => TrySetValue<String>(value);
	}

	public VariableSizeString TestDynamicString
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VirtualList<NMSString0x80> Test0x80ByteStringList
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<Int32> TestListInt
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public MBINCompilerTestTemplate(long address) : base(address)
	{

	}
}
