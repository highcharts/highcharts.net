using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;

namespace HcTests
{
    public class HcFixture : IDisposable
    {
        public ChartType ChartType { get; set; }
        //public Highcharts Options { get; set; }

        //public HighchartsRenderer Renderer { get; set; }

        public HcFixture()
        {
            ChartType = ChartType.Line;
            //Options = new Highcharts();
            //Options.Chart.Type = ChartType;
            //Renderer = new HighchartsRenderer(Options);
        }
        
        public void Dispose()
        {
        }
    }
}
