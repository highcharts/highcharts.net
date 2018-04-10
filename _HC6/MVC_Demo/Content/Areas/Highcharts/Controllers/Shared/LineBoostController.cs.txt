using System.Web.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult LineBoost()
        {
            ViewData["data"] = DataReceiver.GetDataForLineBoost(500000);

            return View();
        }

    }
}
