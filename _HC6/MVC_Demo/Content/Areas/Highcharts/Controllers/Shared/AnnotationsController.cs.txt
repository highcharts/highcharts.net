using MVC_Demo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;

namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult Annotations()
        {
            List<AnnotationsData> rawList = DataReceiver.GetDataForAnnotationsChart();
            List<AreaSeriesData> list = new List<AreaSeriesData>();

            foreach (var item in rawList)
                list.Add(new AreaSeriesData { X = item.X, Y = item.Y });//X = item.X,

            ViewData["data"] = list;

            return View();
        }
        
    }
}
