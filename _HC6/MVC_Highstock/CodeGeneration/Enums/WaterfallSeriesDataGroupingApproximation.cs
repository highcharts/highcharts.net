using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Highsoft.Web.Mvc.Stocks
{
    public enum WaterfallSeriesDataGroupingApproximation
    {
        Null, 
		Average, 
		Averages, 
		Open, 
		High, 
		Low, 
		Close, 
		Sum
    }
}