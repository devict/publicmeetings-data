using System.Collections.Generic;
using System.Threading.Tasks;
using DevIct.PublicMeetings.Data.Core.Models;

namespace DevIct.PublicMeetings.Data.Core.Parsing
{
    public interface IParser
    {
        Task<ICollection<Meeting>> Parse(DataSource dataSource);
    }
}
