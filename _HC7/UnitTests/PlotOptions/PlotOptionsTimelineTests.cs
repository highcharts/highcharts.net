using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;

namespace HcTests.PlotOptions
{
    public class PlotOptionsTimelineTests : PlotOptionsLineTests
    {
        public PlotOptionsTimelineTests(HcFixture fixture) : base(fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Timeline;
        }
    }
}
