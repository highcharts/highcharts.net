using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Highsoft.Web.Mvc.Stocks;
using Highsoft.Web.Mvc.Stocks.Rendering;

namespace UnitTests.HS
{
    public class HsFixture : IDisposable
    {
        public ChartType ChartType { get; set; }
        //public List<string> RootPath;
        //public Highcharts Options { get; set; }

        //public HighchartsRenderer Renderer { get; set; }

        public HsFixture()
        {
            ChartType = ChartType.Sma;
            //RootPath = new List<string>();
            //Options = new Highcharts();
            //Options.Chart.Type = ChartType;
            //Renderer = new HighchartsRenderer(Options);
        }

        public void Dispose()
        {
        }
    }
}
