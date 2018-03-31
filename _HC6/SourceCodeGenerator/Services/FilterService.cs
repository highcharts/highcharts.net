using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeGenerator.Services
{
    //for xAxis.units new solution should be created
    public class FilterService : IFilterService
    {
        private IList<string> IgnoreValuesForFullNames = new List<string> { "plotOptions.series.dataLabels.filter.operator", "data.dateFormat" };
        private IList<string> IgnoreItems = new List<string> { "plotOptions.arearange.dataLabels.align", "plotOptions.arearange.dataLabels.verticalAlign", "plotOptions.column.dataGrouping", "xAxis.units", "plotOptions.tilemap.data", "plotOptions.series.dataGrouping.units", "plotOptions.series.navigatorOptions", "plotOptions.sma.name" };

        public bool IsValuesPropertyIgnored(string fullName)
        {
            if (IgnoreValuesForFullNames.Any(p => p == fullName))
                return true;

            return false;
        }

        public bool IsItemIgnored(string fullName)
        {
            if (IgnoreItems.Any(p => p == fullName))
                return true;

            return false;
        }
    }

    public interface IFilterService
    {
        bool IsValuesPropertyIgnored(string fullName);
        bool IsItemIgnored(string fullName);
    }
}
