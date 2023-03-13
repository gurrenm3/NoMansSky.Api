using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScannerIcons : NMSTemplate
{
	public GcScannerIcon TaggedBuilding
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon Ship
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon Vehicle
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon Freighter
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon FreighterBase
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon PlayerFreighter
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon DamagedFrigate
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon PurchasableFrigate
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon Expedition
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon PlayerBase
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon EditingBase
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon Death
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon Bounty1
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon Bounty2
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon Bounty3
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon Battle
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon ShipSmall
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon DeathSmall
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon BountySmall
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon BattleSmall
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon TimedEvent
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon Checkpoint
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon Garage
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon NPC
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon SettlementNPC
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon CircleAnimation
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon HexAnimation
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon DiamondAnimation
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon ArrowSmall
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon ArrowLarge
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public VirtualArray<GcScannerIcon> GenericIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<GcScannerIcon>(address + GetOffset(), 6));
		set => TrySetValue<GcScannerIcon>(value);
	}

	public VirtualArray<GcScannerIcon> BuildingIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<GcScannerIcon>(address + GetOffset(), 33));
		set => TrySetValue<GcScannerIcon>(value);
	}

	public VirtualArray<GcScannerIcon> BuildingIconsBinocs
	{
		get => cache.GetOrAddValue(new VirtualArray<GcScannerIcon>(address + GetOffset(), 33));
		set => TrySetValue<GcScannerIcon>(value);
	}

	public VirtualArray<GcScannerIcon> BuildingIconsHuge
	{
		get => cache.GetOrAddValue(new VirtualArray<GcScannerIcon>(address + GetOffset(), 33));
		set => TrySetValue<GcScannerIcon>(value);
	}

	public VirtualArray<GcScannerIcon> ScannableIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<GcScannerIcon>(address + GetOffset(), 54));
		set => TrySetValue<GcScannerIcon>(value);
	}

	public VirtualArray<GcScannerIcon> ScannableIconsBinocs
	{
		get => cache.GetOrAddValue(new VirtualArray<GcScannerIcon>(address + GetOffset(), 54));
		set => TrySetValue<GcScannerIcon>(value);
	}

	public VirtualArray<Colour> ScannableColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 54));
		set => TrySetValue<Colour>(value);
	}

	public Colour BuildingColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour GenericColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour RelicColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SignalColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour UnknownColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcScannerIcon CreatureDiscovered
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon CreatureUndiscovered
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon CreatureUnknown
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon MessageBeacon
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon MessageBeaconSmall
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon BaseBuildingMarker
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon PlanetPoleNorth
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon PlanetPoleSouth
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon MonumentMarker
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon NetworkPlayerMarker
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon NetworkPlayerMarkerShip
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon NetworkPlayerMarkerVehicle
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public VirtualArray<GcScannerIcon> NetworkFSPlayerMarkers
	{
		get => cache.GetOrAddValue(new VirtualArray<GcScannerIcon>(address + GetOffset(), 4));
		set => TrySetValue<GcScannerIcon>(value);
	}

	public VirtualArray<GcScannerIcon> NetworkFSPlayerMarkersShip
	{
		get => cache.GetOrAddValue(new VirtualArray<GcScannerIcon>(address + GetOffset(), 4));
		set => TrySetValue<GcScannerIcon>(value);
	}

	public VirtualArray<Colour> NetworkFSPlayerColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 4));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<GcScannerIcon> NetworkPlayerFreighter
	{
		get => cache.GetOrAddValue(new VirtualArray<GcScannerIcon>(address + GetOffset(), 4));
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon PortalMarker
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon BlackHole
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon CreatureCurious
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon CreatureAction
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon CreatureTame
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon CreatureDanger
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon CreatureFiend
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon CreatureMilk
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public VirtualArray<TkTextureResource> HighlightIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 5));
		set => TrySetValue<TkTextureResource>(value);
	}

	public GcScannerIcon MissionEnterOrbit
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon MissionEnterBuilding
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon MissionEnterStation
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon MissionEnterFreighter
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon MissionAbandonedFreighter
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon CreatureInteraction
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon PetInteraction
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon Pet
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon PetSad
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon PetActivity
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon PlayerSettlement
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon OtherPlayerSettlement
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon FriendlyDrone
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon PirateRaid
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcon FuelAsteroid
	{
		get => GetValue<GcScannerIcon>();
		set => TrySetValue<GcScannerIcon>(value);
	}

	public GcScannerIcons(long address) : base(address)
	{

	}
}
