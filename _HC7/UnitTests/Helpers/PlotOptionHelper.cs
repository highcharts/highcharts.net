using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Highsoft.Web.Mvc.Charts;

namespace UnitTests.Helpers
{
    internal class PlotOptionHelper
    {
        public PlotOptions Get(ChartType type)
        {
            switch(type)
            {
                case ChartType.Line:
                    return new PlotOptionsLine();
            }
        }
    }
}
