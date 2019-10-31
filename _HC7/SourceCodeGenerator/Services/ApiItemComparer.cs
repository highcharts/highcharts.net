using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeGenerator.Services
{
    class ApiItemComparer : IEqualityComparer<ApiItem>
    {
        public bool Equals(ApiItem item1, ApiItem item2)
        {
            return item1.Title.Equals(item2.Title);
        }

        public int GetHashCode(ApiItem item)
        {
            return item.GetHashCode();
        }
    }
}
