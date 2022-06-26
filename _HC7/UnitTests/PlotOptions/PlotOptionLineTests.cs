using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;

namespace HC.PlotOptions
{
    public class PlotOptionLineTests : PlotOptionSeriesTests
    {
        public PlotOptionLineTests(HcFixture fixture) : base(fixture)
        {
            _fixture = fixture;
            _fixture.ChartType = ChartType.Line;
        }

        //[Theory(Skip = "it doesn't exist in this object")]
        //[InlineData("Description")]
        //public override void Test_IfAccessibilityDescriptionRenders_Correct(string description)
        //{
            
        //}
    }
}
