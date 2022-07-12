using Reloaded.ModHelper;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// A container for all creature mbin files in NMS.
    /// </summary>
    public interface ICreatureManager
    {
        /// <summary>
        /// Called whenever a CreatureDescriptionFile is loaded.
        /// Passes the ICreatureDescriptionFile file that was loaded as an argument.
        /// </summary>
        public IModEvent<ICreatureDescriptionFile> OnCreatureDescriptionLoaded { get; set; }

        /// <summary>
        /// Contains all of the CreatureRoleDescriptionTable's.
        /// </summary>
        public List<ICreatureDescriptionFile> CreatureDescriptions { get; }

        /// <summary>
        /// Represents the CreatureAudioTable file. 
        /// <br/>The exact mbin type is GcCreatureAudioTable.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\ECOSYSTEM
        /// </summary>
        public ICreatureAudioFile CreatureAudio { get; }

        /// <summary>
        /// Represents the CreatureBehaviorTrees file. 
        /// <br/>The exact mbin type is GcCreatureBehaviourTrees.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\ECOSYSTEM
        /// </summary>
        public ICreatureBehaviorFile CreatureBehaviors { get; }

        /// <summary>
        /// Represents the CreatureDataTable file. 
        /// <br/>The exact mbin type is GcCreatureDataTable.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\ECOSYSTEM
        /// </summary>
        public ICreatureDataFile CreatureDataTable { get; }

        /// <summary>
        /// Represents a Creature Filename Table mbin file.
        /// <br/>The exact mbin type is GcCreatureFilenameTable.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\ECOSYSTEM
        /// </summary>
        public ICreatureFilenameFile CreatureFilenames { get; }

        /// <summary>
        /// Represents a Creature Generation Archetypes mbin file.
        /// <br/>The exact mbin type is GcCreatureGenerationArchetypes.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\ECOSYSTEM
        /// </summary>
        public ICreatureGenArchetypesFile GenerationArchetypes { get; }

        /// <summary>
        /// Represents a Creature Generation Data mbin file.
        /// <br/>The exact mbin type is GcCreatureGenerationData.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\ECOSYSTEM
        /// </summary>
        public ICreatureGenDataFile GenerationData { get; }

        /// <summary>
        /// Represents a Creature Role Filename Table mbin file.
        /// <br/>The exact mbin type is GcCreatureRoleFilenameTable.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\ECOSYSTEM
        /// </summary>
        public ICreatureRoleDescriptionsFile CreatureRoleDescriptions { get; }

        /// <summary>
        /// Represents a Creature Pet Behavior Table mbin file.
        /// <br/>The exact mbin type is GcPetBehaviourTable.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\ECOSYSTEM
        /// </summary>
        public IPetBehaviorFile PetBehaviors { get; }

        /// <summary>
        /// Represents a Creature Pet Accessory mbin file.
        /// <br/>The exact mbin type is GcPetAccessoryTable.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\ECOSYSTEM
        /// </summary>
        public IPetAccessoryFile PetAccessories { get; }

        /// <summary>
        /// Represents a Pet Egg Species Override Table mbin file.
        /// <br/>The exact mbin type is GcPetEggSpeciesOverrideTable.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\ECOSYSTEM
        /// </summary>
        public IPetEggSpeciesOverrideFile PetEggSpeciesOverride { get; }

        /// <summary>
        /// Represents a Pet Egg Trait Modifier Override Table mbin file.
        /// <br/>The exact mbin type is GcPetEggTraitModifierOverrideTable.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\ECOSYSTEM
        /// </summary>
        public IPetEggTraitModifierFile PetEggTraitModifier { get; }

        /// <summary>
        /// Represents the RobotDataTable file. 
        /// <br/>The exact mbin type is GcCreatureDataTable.
        /// <br/><br/>This mbin file is located in METADATA\SIMULATION\ECOSYSTEM
        /// </summary>
        public ICreatureDataFile RobotDataTable { get; }
    }
}
