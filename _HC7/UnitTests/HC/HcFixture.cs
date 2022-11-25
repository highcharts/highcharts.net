using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;
using TH = Tests.Helpers.TestHelper;

namespace UnitTests.HC
{
    public class HcFixture : IDisposable
    {
        private ChartType _chartType;
        public ChartType ChartType 
        { 
            get
            {
                return _chartType;
            } 
            set
            {
                _chartType = value;
                Series = TH.GetHcSeries(_chartType);
            }
        }
        public Series Series 
        { 
            get; 
            private set; 
        }

        public HcFixture()
        {
            Series = new Series();
        }

        public void Reset()
        {
            Series = new Series();
        }

        public void Dispose()
        {
        }
    }
}
