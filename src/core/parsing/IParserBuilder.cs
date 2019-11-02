namespace DevIct.PublicMeetings.Data.Core.Parsing
{
    /// <summary>
    /// Defines the contract to build a IParser
    /// </summary>
    public interface IParserBuilder
    {
        /// <summary>
        /// Configures the IParserBuilder
        /// </summary>
        /// <param name="options">
        /// The <see cref="ParserBuilderOptions"> to use to configure the builder.
        /// </param>
        void ConfigureBuilder(ParserBuilderOptions options);

        /// <summary>
        /// Builds an <see cref="IParser"> based on the configuration
        /// </summary>
        /// <exception cref="System.InvalidOperationException">
        /// Thrown when this method is called without calling ConfigureBuilder first
        /// </exception>
        /// <returns>
        /// An <see cref="IParser"> that matches the configuration options passed in ConfigureBuilder
        /// </returns>
        /// <remarks>
        /// Call ConfigureBuilder first you idiot.
        /// </remarks>
        IParser Build();
    }
}
