using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DevIct.PublicMeetings.Data.Core.Models
{
    public class FieldMap
    {
        private readonly ICollection<Field> _items = new HashSet<Field>();

        public ICollection<string> SourceNames => throw new System.NotImplementedException();

        public bool Add(Field field)
        {
            if (!_items.Any(f => f.ApiName.Equals(field.ApiName)))
            {
                _items.Add(field);
                return true;
            }
            return false;
        }

        public PropertyInfo GetInfoFor(string sourceName)
        {
            throw new System.NotImplementedException();
        }
    }
}
