using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeGenerator.Services
{
    public class FilterService : IFilterService
    {
        private IList<string> IgnoreValuesForFullNames = new List<string> { "plotOptions.series.dataLabels.filter.operator" };

        public bool IsIgnoredValuesProperty(string fullName)
        {
            if (IgnoreValuesForFullNames.Any(p => p == fullName))
                return true;

            return false;
        }
    }

    public interface IFilterService
    {
        bool IsIgnoredValuesProperty(string fullName);
    }
}
