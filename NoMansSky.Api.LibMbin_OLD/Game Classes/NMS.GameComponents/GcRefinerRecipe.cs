using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRefinerRecipe : NMSTemplate
{
	public NMSString0x20A Id
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A RecipeType
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A RecipeName
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single TimeToMake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Cooking
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRefinerRecipeElement Result
	{
		get => GetValue<GcRefinerRecipeElement>();
		set => TrySetValue<GcRefinerRecipeElement>(value);
	}

	public VirtualList<GcRefinerRecipeElement> Ingredients
	{
		get => cache.GetOrAddValue(new VirtualList<GcRefinerRecipeElement>(address + GetOffset()));
		set => TrySetValue<GcRefinerRecipeElement>(value);
	}

	public GcRefinerRecipe(long address) : base(address)
	{

	}
}
