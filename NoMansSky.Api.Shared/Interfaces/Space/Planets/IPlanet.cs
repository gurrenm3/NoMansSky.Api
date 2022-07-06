namespace NoMansSky.Api
{
    /// <summary>
    /// Represents a planet
    /// </summary>
    public interface IPlanet
    {
        /// <summary>
        /// The address to GcPlanetData for this Planet.
        /// </summary>
        public long PlanetDataAddress { get; }

        /// <summary>
        /// A shortcut for getting the planet's name.
        /// </summary>
        public string Name { get; }
    }
}
