using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;


namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult Columnrange()
        {
            List<ColumnrangeSeriesData> temperatureData = new List<ColumnrangeSeriesData>();

            temperatureData.Add(new ColumnrangeSeriesData { Low = -9.7, High = 9.4  });
            temperatureData.Add(new ColumnrangeSeriesData { Low = -8.7, High = 6.5  });
            temperatureData.Add(new ColumnrangeSeriesData { Low =  -3.5, High = 9.4  });
            temperatureData.Add(new ColumnrangeSeriesData { Low = -1.4, High = 19.9 });
            temperatureData.Add(new ColumnrangeSeriesData { Low = 0.0, High = 22.6 });
            temperatureData.Add(new ColumnrangeSeriesData { Low = 2.9, High = 29.5 });
            temperatureData.Add(new ColumnrangeSeriesData { Low = 9.2, High = 30.7  });
            temperatureData.Add(new ColumnrangeSeriesData { Low = 7.3, High = 26.5 });
            temperatureData.Add(new ColumnrangeSeriesData { Low = 4.4, High = 18.0 });
            temperatureData.Add(new ColumnrangeSeriesData { Low = -3.1, High = 11.4 });
            temperatureData.Add(new ColumnrangeSeriesData { Low = -5.2, High = 10.4  });
            temperatureData.Add(new ColumnrangeSeriesData { Low = -13.5, High = 9.8 });

            ViewData["temperatureData"] = temperatureData;

            return View();
        }
    }
}
