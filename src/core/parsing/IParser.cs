using System.Collections.Generic;
using System.Threading.Tasks;
using DevIct.PublicMeetings.Data.Core.Models;

namespace DevIct.PublicMeetings.Data.Core.Parsing
{
    /// <summary>
    /// The contract for a Parser of a DataSource
    /// </summary>
    public interface IParser
    {
        /// <summary>
        /// Attempts to parse <paramref name="dataSource">
        /// </summary>
        /// <param name="dataSource">
        /// The <see cref="DataSource"> to parse
        /// </param>
        /// <returns>
        /// A <see cref="Task{T}"> with the result of the parsing operation
        /// </returns>
        Task<ICollection<Meeting>> Parse(DataSource dataSource);

        /// <summary>
        /// Adds <paramref name="fields"> to the fields to include in the output
        /// </summary>
        void IncludeFields(FieldMap fields);
    }
}
