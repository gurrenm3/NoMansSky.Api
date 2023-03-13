using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGeneratedBaseTemplatesTable : NMSTemplate
{
	public VirtualList<GcGeneratedBaseDecorationTemplate> DecorationTemplates
	{
		get => cache.GetOrAddValue(new VirtualList<GcGeneratedBaseDecorationTemplate>(address + GetOffset()));
		set => TrySetValue<GcGeneratedBaseDecorationTemplate>(value);
	}

	public VirtualList<GcGeneratedBaseRoomTemplate> RoomTemplates
	{
		get => cache.GetOrAddValue(new VirtualList<GcGeneratedBaseRoomTemplate>(address + GetOffset()));
		set => TrySetValue<GcGeneratedBaseRoomTemplate>(value);
	}

	public VirtualList<GcGeneratedBaseThemeTemplate> ThemeTemplates
	{
		get => cache.GetOrAddValue(new VirtualList<GcGeneratedBaseThemeTemplate>(address + GetOffset()));
		set => TrySetValue<GcGeneratedBaseThemeTemplate>(value);
	}

	public VirtualList<GcGeneratedBasePruningRule> PruningRules
	{
		get => cache.GetOrAddValue(new VirtualList<GcGeneratedBasePruningRule>(address + GetOffset()));
		set => TrySetValue<GcGeneratedBasePruningRule>(value);
	}

	public GcGeneratedBaseTemplatesTable(long address) : base(address)
	{

	}
}
