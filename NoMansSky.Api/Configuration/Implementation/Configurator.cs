using Reloaded.Mod.Interfaces;
using System.IO;

namespace NoMansSky.Api.Configuration.Implementation
{
    public class Configurator : IConfiguratorV2
    {
        /* Migration Guide from V1 to V2:
            - Copy this class to your V1 mod; re-add any changes made to `MakeConfigurations`.
            - Add Migrate function; it should use File.Move to copy config files from old to new directory.
            - In Program.cs Start function, add a call to `Migrate` before calling `GetConfiguration`.
                configurator.Migrate(_modLoader.GetDirectoryForModId(_modConfig.ModId), configurator.ConfigFolder);
        */

        /// <summary>
        /// The folder where the modification files are stored.
        /// </summary>
        public string ModFolder { get; private set; }

        /// <summary>
        /// Full path to the config folder.
        /// </summary>
        public string ConfigFolder { get; private set; }

        /// <summary>
        /// Returns a list of configurations.
        /// </summary> 
        public IUpdatableConfigurable[] Configurations => _configurations ?? MakeConfigurations();
        private IUpdatableConfigurable[] _configurations;

        private IUpdatableConfigurable[] MakeConfigurations()
        {
            _configurations = new IUpdatableConfigurable[]
            {
                // Add more configurations here if needed.
                Configurable<Config>.FromFile(Path.Combine(ConfigFolder, "Config.json"), "Default Config")
            };

            // Add self-updating to configurations.
            for (int x = 0; x < Configurations.Length; x++)
            {
                var xCopy = x;
                Configurations[x].ConfigurationUpdated += configurable =>
                {
                    Configurations[xCopy] = configurable;
                };
            }

            return _configurations;
        }

        public Configurator() { }
        public Configurator(string configDirectory) : this()
        {
            ConfigFolder = configDirectory;
        }

        /* Configurator V2 */

        /// <summary>
        /// Migrates from the old config location to the newer config location.
        /// </summary>
        /// <param name="oldDirectory">Old directory containing the mod configs.</param>
        /// <param name="newDirectory">New directory pointing to user config folder.</param>
        public void Migrate(string oldDirectory, string newDirectory)
        {
            /*
                To be implemented by mod author migrating from older to newer config directory.
                Simply File.Move the config files in `MakeConfigurations` from old to new directory.
            */
        }

        /* Configurator */

        /// <summary>
        /// Gets an individual user configuration.
        /// </summary>
        public TType GetConfiguration<TType>(int index) => (TType)Configurations[index];

        /* IConfigurator. */

        /// <summary>
        /// Sets the config directory for the Configurator.
        /// </summary>
        public void SetConfigDirectory(string configDirectory) => ConfigFolder = configDirectory;

        /// <summary>
        /// Returns a list of user configurations.
        /// </summary>
        public IConfigurable[] GetConfigurations() => Configurations;

        /// <summary>
        /// Allows for custom launcher/configurator implementation.
        /// If you have your own configuration program/code, run that code here and return true, else return false.
        /// </summary>
        public bool TryRunCustomConfiguration() => false;

        /// <summary>
        /// Sets the mod directory for the Configurator.
        /// </summary>
        public void SetModDirectory(string modDirectory) { ModFolder = modDirectory; }
    }
}
