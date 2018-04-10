using Highsoft.Web.Mvc.Charts;
using MVC_Demo.Models;
using System.Web.Mvc;


namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult ScatterBoost()
        {
            ViewData["Data"] = DataReceiver.GetDataForScatterBoost(1000000);

            return View();
        }

    }
}
