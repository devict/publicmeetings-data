using System.Collections.Generic;

namespace DevIct.PublicMeetings.Data.Core.Parsing
{
    /// <summary>
    /// Represents the options supported by the IParserBuilder
    /// </summary>
    public class ParserBuilderOptions
    {
        /// <summary>
        /// The format of the <see cref="DataSource"> to build the <see cref="IParser"> for
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// The fields to retrieve from the <see cref="DataSource">
        /// </summary>
        public IDictionary<string, string> Fields { get; set; }
    }
}
