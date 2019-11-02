using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIct.PublicMeetings.Data.Core.Parsing
{
    public interface IParser
    {
        Task<ICollection<Meeting>> Parse(DataSource dataSource);
    }
}
