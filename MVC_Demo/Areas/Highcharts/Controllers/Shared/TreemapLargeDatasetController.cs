using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc;


namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult TreemapLargeDataset()
        {
            dynamic dataLabels = new System.Dynamic.ExpandoObject();
            dataLabels.enabled = true;

            ViewData["dataLabels"] = dataLabels;

            return View();
        }
    }
}
