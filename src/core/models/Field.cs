using System.Reflection;

namespace DevIct.PublicMeetings.Data.Core.Models
{
    /// <summary>
    /// Represents a field mapping used to parse a <see cref="DataSource">
    /// </summary>
    public class Field
    {
        /// <summary>
        /// The name used for the field in the <see cref="DataSource">
        /// </summary>
        public string SourceName { get; set; }

        /// <summary>
        /// The property of <see cref="Message"> to map to
        /// </summary>
        public PropertyInfo ApiName { get; set; }
    }
}
