using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTradeSettings : NMSTemplate
{
	public GcTradeData SpaceStation
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData Shop
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData TechShop
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData ShipTechSpecialist
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData SuitTechSpecialist
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData WeapTechSpecialist
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData VehicleTechSpecialist
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData NexusTechSpecialist
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData Ship
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData ExpShip
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData TraShip
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData WarShip
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData LoneExp
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData LoneTra
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData LoneWar
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData MapShop
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData IllegalProds
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData Scrap
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData SeasonRewardsShop
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData SmugglerStation
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData PirateTech
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeData PirateVisitor
	{
		get => GetValue<GcTradeData>();
		set => TrySetValue<GcTradeData>(value);
	}

	public GcTradeSettings(long address) : base(address)
	{

	}
}
