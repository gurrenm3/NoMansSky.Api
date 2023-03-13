using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTestMetadata : NMSTemplate
{
	public Boolean TestBool
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Byte TestByte
	{
		get => GetValue<Byte>();
		set => TrySetValue<Byte>(value);
	}

	public Int32 TestInt
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int16 TestInt16
	{
		get => GetValue<Int16>();
		set => TrySetValue<Int16>(value);
	}

	public UInt16 TestUInt16
	{
		get => GetValue<UInt16>();
		set => TrySetValue<UInt16>(value);
	}

	public Int64 TestInt64
	{
		get => GetValue<Int64>();
		set => TrySetValue<Int64>(value);
	}

	public UInt64 TestUInt64
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Int64 TestInt64_2
	{
		get => GetValue<Int64>();
		set => TrySetValue<Int64>(value);
	}

	public UInt64 TestUInt64_2
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public GcResource TestResource
	{
		get => GetValue<GcResource>();
		set => TrySetValue<GcResource>(value);
	}

	public Vector3f TestVector
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector2f TestVector2
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector4f TestVector4
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Colour TestColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single TestFloat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSeed TestSeed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public NMSString0x80 TestModelFilename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 TestTextureFilename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x20 TestString
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x80 TestString128
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x100 TestString256
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x200 TestString512
	{
		get => GetValue<NMSString0x200>();
		set => TrySetValue<NMSString0x200>(value);
	}

	public NMSString0x10 TestID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A TestLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcAudioWwiseEvents TestAudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public Vector3f DocOptionalVector
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public NMSString0x40 DocRenamedString64
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public NMSString0x20A DocOptionalRenamed
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public libMBIN.NMS.GameComponents.GcTestMetadata.DocOptionalEnumEnum DocOptionalEnum
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcTestMetadata.DocOptionalEnumEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcTestMetadata.DocOptionalEnumEnum>(value);
	}

	public VariableSizeString TestDynamicString
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public libMBIN.NMS.GameComponents.GcTestMetadata.TestEnumEnum TestEnum
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcTestMetadata.TestEnumEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcTestMetadata.TestEnumEnum>(value);
	}

	public VirtualArray<Single> TestStaticArray
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 10));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> TestDynamicArray
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> TestEnumArray
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> TestExternalEnumArray
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 52));
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcTestMetadata.TestFlagsEnum TestFlags
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcTestMetadata.TestFlagsEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcTestMetadata.TestFlagsEnum>(value);
	}

	public GcTestMetadata(long address) : base(address)
	{

	}
}
