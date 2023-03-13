/*using libMBIN.NMS.GameComponents;
using NoMansSky.Api;
using Reloaded.ModHelper;

namespace NoMansSky.Api.LibMbin
{
    public unsafe class GcPlayerStateData_Internal : MbinClass
    {
        [FindOffset(searchPattern: "41 88 8E ? ? ? ? 8B 0D ? ? ? ? ", numBytesToOffset: 3)]
        public bool IsNew
        {
            get => GetValue<bool>();
            set => TrySetValue<bool>(value);
        }


        //[FindOffset(searchPattern: "41 89 86 ? ? ? ? 49 8B D7 ", numBytesToOffset: -11)]
        public int Shield
        {
            get => GetValue<int>();
            set => TrySetValue<int>(value);
        }


        //[FindOffset(searchPattern: "41 89 86 ? ? ? ? 49 8B D7 ", numBytesToOffset: -25)]
        public int Health
        {
            get => GetValue<int>();
            set => TrySetValue<int>(value);
        }


        [FindOffset(searchPattern: "41 89 86 ? ? ? ? 49 8B D7 ", numBytesToOffset: 3)]
        public int ShipHealth
        {
            get => GetValue<int>();
            set => TrySetValue<int>(value);
        }


        [FindOffset(searchPattern: "C6 44 24 ? ? 41 8B 87 ? ? ? ? 41 89 86 ? ? ? ? ", numBytesToOffset: 15)]
        public int Units
        {
            get => GetValue<int>();
            set => TrySetValue<int>(value);
        }

        [FindOffset(searchPattern: "C6 44 24 ? ? 41 8B 87 ? ? ? ? 41 89 86 ? ? ? ? ", numBytesToOffset: 29)]
        public int Nanites
        {
            get => GetValue<int>();
            set => TrySetValue<int>(value);
        }


        [FindOffset(searchPattern: "C6 44 24 ? ? 41 8B 87 ? ? ? ? 41 89 86 ? ? ? ? ", numBytesToOffset: 43)]
        public int Specials
        {
            get => GetValue<int>();
            set => TrySetValue<int>(value);
        }


        [FindOffset(searchPattern: "41 89 86 ? ? ? ? 49 8D 97 ? ? ? ? ", numBytesToOffset: 3)]
        public int ProcTechIndex
        {
            get => GetValue<int>();
            set => TrySetValue<int>(value);
        }


        [FindOffset(searchPattern: "41 89 86 ? ? ? ? 49 8D 97 ? ? ? ? ", numBytesToOffset: 17)]
        public GcInteractionData HoloExplorerInteraction
        {
            get => GetValue<GcInteractionData>();
            set => TrySetValue<GcInteractionData>(value);
        }


        [FindOffset(searchPattern: "41 89 86 ? ? ? ? 49 8D 97 ? ? ? ? ", numBytesToOffset: 36)]
        public GcInteractionData HoloScepticInteraction
        {
            get => GetValue<GcInteractionData>();
            set => TrySetValue<GcInteractionData>(value);
        }


        [FindOffset(searchPattern: "41 89 86 ? ? ? ? 49 8D 97 ? ? ? ? ", numBytesToOffset: 55)]
        public GcInteractionData HoloNooneInteraction
        {
            get => GetValue<GcInteractionData>();
            set => TrySetValue<GcInteractionData>(value);
        }


        [FindOffset(searchPattern: "E8 ? ? ? ? 41 8B 87 ? ? ? ? 41 89 86 ? ? ? ? 41 8B 87 ? ? ? ? ", numBytesToOffset: 15)]
        public GcPlayerWeapons StartingPrimaryWeapon
        {
            get => GetValue<GcPlayerWeapons>();
            set => TrySetValue<GcPlayerWeapons>(value);
        }


        [FindOffset(searchPattern: "E8 ? ? ? ? 41 8B 87 ? ? ? ? 41 89 86 ? ? ? ? 41 8B 87 ? ? ? ? ", numBytesToOffset: 29)]
        public GcPlayerWeapons StartingSecondaryWeapon
        {
            get => GetValue<GcPlayerWeapons>();
            set => TrySetValue<GcPlayerWeapons>(value);
        }


        [FindOffset(searchPattern: "49 8B CE E8 ? ? ? ? 49 8B 87 ? ? ? ? 49 89 86 ? ? ? ? ", numBytesToOffset: 18)]
        public ulong TimeAlive
        {
            get => GetValue<ulong>();
            set => TrySetValue<ulong>(value);
        }

        [FindOffset(searchPattern: "49 8B CE E8 ? ? ? ? 49 8B 87 ? ? ? ? 49 89 86 ? ? ? ? ", numBytesToOffset: 32)]
        public ulong TotalPlayTime
        {
            get => GetValue<ulong>();
            set => TrySetValue<ulong>(value);
        }


        [FindOffset(searchPattern: "49 8B CE E8 ? ? ? ? 49 8B 87 ? ? ? ? 49 89 86 ? ? ? ? ", numBytesToOffset: 46)]
        public ulong HazardTimeAlive
        {
            get => GetValue<ulong>();
            set => TrySetValue<ulong>(value);
        }

        [FindOffset(searchPattern: "49 8B CE E8 ? ? ? ? 49 8B 87 ? ? ? ? 49 89 86 ? ? ? ? ", numBytesToOffset: 60)]
        public int ProgressionLevel
        {
            get => GetValue<int>();
            set => TrySetValue<int>(value);
        }

        [FindOffset(searchPattern: "49 8B CE E8 ? ? ? ? 49 8B 87 ? ? ? ? 49 89 86 ? ? ? ? ", numBytesToOffset: 74)]
        public float VRCameraOffset
        {
            get => GetValue<float>();
            set => TrySetValue<float>(value);
        }

        [FindOffset(searchPattern: "49 8B CE E8 ? ? ? ? 49 8B 87 ? ? ? ? 49 89 86 ? ? ? ? ", numBytesToOffset: 89)]
        public bool ThirdPersonShip
        {
            get => GetValue<bool>();
            set => TrySetValue<bool>(value);
        }

        [FindOffset(searchPattern: "49 8B CE E8 ? ? ? ? 49 8B 87 ? ? ? ? 49 89 86 ? ? ? ? ", numBytesToOffset: 104)]
        public bool UsesThirdPersonVehicleCam
        {
            get => GetValue<bool>();
            set => TrySetValue<bool>(value);
        }

        [FindOffset(searchPattern: "49 8B CE E8 ? ? ? ? 49 8B 87 ? ? ? ? 49 89 86 ? ? ? ? ", numBytesToOffset: 118)]
        public ulong ActiveSpaceBattleUA
        {
            get => GetValue<ulong>();
            set => TrySetValue<ulong>(value);
        }

        [FindOffset(searchPattern: "49 8B CE E8 ? ? ? ? 49 8B 87 ? ? ? ? 49 89 86 ? ? ? ? ", numBytesToOffset: 133)]
        public bool UseSmallerBlackholeJumps
        {
            get => GetValue<bool>();
            set => TrySetValue<bool>(value);
        }

        [FindOffset(searchPattern: "84 C0 74 26 49 8D 97 ? ? ? ? ", numBytesToOffset: 14)]
        public GcUniverseAddressData GameStartAddress1
        {
            get => GetValue<GcUniverseAddressData>();
            set => TrySetValue<GcUniverseAddressData>(value);
        }

        [FindOffset(searchPattern: "84 C0 74 26 49 8D 97 ? ? ? ? ", numBytesToOffset: 33)]
        public GcUniverseAddressData GameStartAddress2
        {
            get => GetValue<GcUniverseAddressData>();
            set => TrySetValue<GcUniverseAddressData>(value);
        }

        [FindOffset(searchPattern: "49 8B D7 49 8D 8E ? ? ? ? E8 ? ? ? ? 49 8D 57 18 ", numBytesToOffset: 6)]
        public GcUniverseAddressData UniverseAddress
        {
            get => GetValue<GcUniverseAddressData>();
            set => TrySetValue<GcUniverseAddressData>(value);
        }

        [FindOffset(searchPattern: "49 8B D7 49 8D 8E ? ? ? ? E8 ? ? ? ? 49 8D 57 18 ", numBytesToOffset: 22)]
        public GcUniverseAddressData PreviousUniverseAddress
        {
            get => GetValue<GcUniverseAddressData>();
            set => TrySetValue<GcUniverseAddressData>(value);
        }


        [FindOffset(searchPattern: "41 0F B6 87 ? ? ? ? 41 88 86 ? ? ? ? 41 80 BF ? ? ? ? ? ", numBytesToOffset: 11)]
        public bool RevealBlackHoles
        {
            get => GetValue<bool>();
            set => TrySetValue<bool>(value);
        }

        [FindOffset(searchPattern: "F3 41 0F 7F 86 ? ? ? ? 41 0F 10 87 ? ? ? ? ", numBytesToOffset: 5)]
        public Vector4f FirstSpawnPosition
        {
            get => GetValue<Vector4f>();
            set => TrySetValue<Vector4f>(value);
        }

        [FindOffset(searchPattern: "F3 41 0F 7F 86 ? ? ? ? 41 0F 10 87 ? ? ? ? ", numBytesToOffset: 22)]
        public Vector4f FirstShipPosition
        {
            get => GetValue<Vector4f>();
            set => TrySetValue<Vector4f>(value);
        }

        [FindOffset(searchPattern: "F3 41 0F 7F 86 ? ? ? ? 41 0F 10 87 ? ? ? ? ", numBytesToOffset: 39)]
        public Vector4f StartGameShipPosition
        {
            get => GetValue<Vector4f>();
            set => TrySetValue<Vector4f>(value);
        }

        [FindOffset(searchPattern: "F3 41 0F 7F 86 ? ? ? ? 41 0F 10 87 ? ? ? ? ", numBytesToOffset: 54)]
        public bool ShipNeedsTerrainPositioning
        {
            get => GetValue<bool>();
            set => TrySetValue<bool>(value);
        }

        [FindOffset(searchPattern: "49 8D 9E ? ? ? ? 49 8D 96 ? ? ? ? ", numBytesToOffset: 3)]
        public GcUniverseAddressData GraveUniverseAddress
        {
            get => GetValue<GcUniverseAddressData>();
            set => TrySetValue<GcUniverseAddressData>(value);
        }

        [FindOffset(searchPattern: "41 88 86 ? ? ? ? 49 8D 9E ? ? ? ? ", numBytesToOffset: 3)]
        public bool SpawnGrave
        {
            get => GetValue<bool>();
            set => TrySetValue<bool>(value);
        }


        [FindOffset(searchPattern: "41 88 86 ? ? ? ? 41 0F 10 9F ? ? ? ? ", numBytesToOffset: 3)]
        public bool SpaceGrave
        {
            get => GetValue<bool>();
            set => TrySetValue<bool>(value);
        }

        [FindOffset(searchPattern: "41 0F 11 AE ? ? ? ? 0F 28 85 ? ? ? ? ", numBytesToOffset: 4)]
        public Vector4f GraveMatrixUp
        {
            get => GetValue<Vector4f>();
            set => TrySetValue<Vector4f>(value);
        }

        [FindOffset(searchPattern: "41 0F 11 AE ? ? ? ? 0F 28 85 ? ? ? ? ", numBytesToOffset: 19)]
        public Vector4f GraveMatrixLookAt
        {
            get => GetValue<Vector4f>();
            set => TrySetValue<Vector4f>(value);
        }

        [FindOffset(searchPattern: "41 0F 11 86 ? ? ? ? 41 0F 10 97 ? ? ? ? ", numBytesToOffset: 4)]
        public Vector4f GravePosition
        {
            get => GetValue<Vector4f>();
            set => TrySetValue<Vector4f>(value);
        }

        [FindOffset(searchPattern: "0F 8C ? ? ? ? 41 0F B6 87 ? ? ? ? 41 88 86 ? ? ? ? ", numBytesToOffset: 17)]
        public bool FirstAtlasStationDiscovered
        {
            get => GetValue<bool>();
            set => TrySetValue<bool>(value);
        }

        [FindOffset(searchPattern: "0F 8C ? ? ? ? 41 0F B6 87 ? ? ? ? 41 88 86 ? ? ? ? ", numBytesToOffset: 32)]
        public bool UsesThirdPersonCharacterCam
        {
            get => GetValue<bool>();
            set => TrySetValue<bool>(value);
        }

        [FindOffset(searchPattern: "48 8D 4D A0 E8 ? ? ? ? 49 8D 97 ? ? ? ? ", numBytesToOffset: 19)]
        public GcExactResource CurrentWeapon
        {
            get => GetValue<GcExactResource>();
            set => TrySetValue<GcExactResource>(value);
        }

        [FindOffset(searchPattern: "49 8D 8E ? ? ? ? E8 ? ? ? ? 4D 8D AE ? ? ? ? ", numBytesToOffset: 15)]
        public GcResourceElement CurrentShip
        {
            get => GetValue<GcResourceElement>();
            set => TrySetValue<GcResourceElement>(value);
        }

        [FindOffset(searchPattern: "0F 8C ? ? ? ? 41 0F 10 87 ? ? ? ? 41 0F 11 86 ? ? ? ? ", numBytesToOffset: 18)]
        public NMSString0x10 JetpackEffect
        {
            get => GetValue<NMSString0x10>();
            set => TrySetValue<NMSString0x10>(value);
        }

        [FindOffset(searchPattern: "41 0F 11 86 ? ? ? ? 49 8D 9E ? ? ? ? 8B 05 ? ? ? ? ", numBytesToOffset: 4)]
        public NMSString0x10 FreighterEngineEffect
        {
            get => GetValue<NMSString0x10>();
            set => TrySetValue<NMSString0x10>(value);
        }

        [FindOffset(searchPattern: "4D 8D 86 ? ? ? ? 48 8D 95 ? ? ? ? 49 8B CE ", numBytesToOffset: 3)]
        public InventoryContainer_Internal Inventory
        {
            get => GetValue<InventoryContainer_Internal>();
            set => TrySetValue<InventoryContainer_Internal>(value);
        }

        public GcPlayerStateData_Internal(long address) : base(address)
        {
            
        }
    }
}
*/