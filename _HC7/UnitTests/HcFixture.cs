using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;

namespace UnitTests
{
    public class HcFixture : IDisposable
    {
        public ChartType ChartType { get; set; }

        public HcFixture()
        {
            ChartType = ChartType.Line;
        }
        
        public void Dispose()
        {
        }
    }
}
