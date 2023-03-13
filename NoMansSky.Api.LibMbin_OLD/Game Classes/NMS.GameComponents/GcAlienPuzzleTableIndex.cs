using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAlienPuzzleTableIndex : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcAlienPuzzleTableIndex.IndexTypeEnum IndexType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAlienPuzzleTableIndex.IndexTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAlienPuzzleTableIndex.IndexTypeEnum>(value);
	}

	public GcAlienPuzzleTableIndex(long address) : base(address)
	{

	}
}
