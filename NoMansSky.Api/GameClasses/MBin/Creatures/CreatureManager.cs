using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// A container for all creature mbin files in NMS.
    /// </summary>
    internal class CreatureManager : ICreatureManager
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<ICreatureDescriptionFile> OnCreatureDescriptionLoaded { get; set; } = new ModEvent<ICreatureDescriptionFile>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public List<ICreatureDescriptionFile> CreatureDescriptions { get; } = new List<ICreatureDescriptionFile>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ICreatureAudioFile CreatureAudio { get; } = new CreatureAudioFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ICreatureBehaviorFile CreatureBehaviors { get; } =  new CreatureBehaviorFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ICreatureDataFile CreatureDataTable { get; } = new CreatureDataFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ICreatureFilenameFile CreatureFilenames { get; } = new CreatureFilenameFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ICreatureGenArchetypesFile GenerationArchetypes { get; } = new CreatureGenArchetypesFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ICreatureGenDataFile GenerationData { get; } = new CreatureGenDataFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ICreatureRoleDescriptionsFile CreatureRoleDescriptions { get; } = new CreatureRoleDescriptionsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IPetBehaviorFile PetBehaviors { get; } = new PetBehaviorFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IPetAccessoryFile PetAccessories { get; } = new PetAccessoryFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IPetEggSpeciesOverrideFile PetEggSpeciesOverride { get; } = new PetEggSpeciesOverrideFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IPetEggTraitModifierFile PetEggTraitModifier { get; } = new PetEggTraitModifierFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ICreatureDataFile RobotDataTable { get; } = new CreatureDataFile();

        /// <summary>
        /// Creatures an instance of this class.
        /// </summary>
        public CreatureManager()
        {
            IGame.Instance.MBinManager.OnMBinLoaded.AddListener(mbin =>
            {
                string fullname = mbin.FullName.ToUpper();
                if (!fullname.Contains("METADATA/SIMULATION/ECOSYSTEM"))
                    return;

                // depreciated stuff not currently supported.
                if (fullname.Contains("DEPRECATE"))
                    return;

                // it's a creature description file.
                if (fullname.Contains("AIR") || fullname.Contains("CAVE") || fullname.Contains("GROUND") || fullname.Contains("UNDERWATER"))
                {
                    var creatureDescription = new CreatureDescriptionFile();
                    creatureDescription.MBin = mbin;
                    CreatureDescriptions.Add(creatureDescription);
                    OnCreatureDescriptionLoaded.Invoke(creatureDescription);
                    return;
                }

                IMBinWrapper wrapperClass = null;
                if (fullname.Contains("CREATUREAUDIOTABLE"))
                {
                    wrapperClass = CreatureAudio;
                }
                else if (fullname.Contains("CREATUREBEHAVIOURTREES"))
                {
                    wrapperClass = CreatureBehaviors;
                }
                else if (fullname.Contains("CREATUREDATATABLE"))
                {
                    wrapperClass = CreatureDataTable;
                }
                else if (fullname.Contains("CREATUREFILENAMETABLE"))
                {
                    wrapperClass = CreatureFilenames;
                }
                else if (fullname.Contains("CREATUREGENERATIONARCHETYPES"))
                {
                    wrapperClass = GenerationArchetypes;
                }
                else if (fullname.Contains("CREATUREGENERATIONDATA"))
                {
                    wrapperClass = GenerationData;
                }
                else if (fullname.Contains("CREATUREPETBEHAVIOURTABLE"))
                {
                    wrapperClass = PetBehaviors;
                }
                else if (fullname.Contains("CREATUREROLEDESCRIPTIONTABLE"))
                {
                    wrapperClass = CreatureRoleDescriptions;
                }
                else if (fullname.Contains("PETACCESSORYTABLE"))
                {
                    wrapperClass = PetAccessories;
                }
                else if (fullname.Contains("PETEGGSPECIESOVERRIDETABLE"))
                {
                    wrapperClass = PetEggSpeciesOverride;
                }
                else if (fullname.Contains("PETEGGTRAITMODIFIEROVERRIDETABLE"))
                {
                    wrapperClass = PetEggTraitModifier;
                }
                else if (fullname.Contains("ROBOTDATATABLE"))
                {
                    wrapperClass = RobotDataTable;
                }


                if (wrapperClass != null)
                {
                    wrapperClass.MBin = mbin;
                    wrapperClass.OnLoaded.Invoke();
                }
                else
                {
                    ConsoleUtil.LogError($"Failed to load creature mbin file. Filename: {mbin.FullName}");
                }
            });
        }
    }
}
