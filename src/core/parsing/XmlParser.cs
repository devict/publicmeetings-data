using System.Collections.Generic;
using System.Threading.Tasks;
using DevIct.PublicMeetings.Data.Core.Models;

namespace DevIct.PublicMeetings.Data.Core.Parsing
{
    internal class XmlParser : IParser
    {
        public Task<ICollection<Meeting>> Parse(DataSource dataSource)
        {
            throw new System.NotImplementedException();
        }

        public void IncludeFields(FieldMap fields)
        {
            throw new System.NotImplementedException();
        }
    }
}
