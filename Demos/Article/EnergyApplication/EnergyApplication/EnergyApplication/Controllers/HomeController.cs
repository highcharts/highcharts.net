using EnergyApplication.Models;
using EnergyApplication.Services;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace EnergyApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
                
        public async Task<ActionResult> About()
        {
            var dataSource = await DataService.GetAsync(Server.MapPath("~/App_Data/fuels.csv"),int.MinValue,int.MaxValue);
            ViewData["fuels"] = dataSource;
            //ViewData["functionName"] = null;
            
            return View();
        }

        //public ActionResult AllFuelsInTime()
        //{
        //    var dataSource = DataService.Get(Server.MapPath("~/App_Data/fuels.csv"), int.MinValue, int.MaxValue);
        //    ViewData["fuels"] = dataSource;
        //    return PartialView("AllFuelsInTime");
        //}

        [HttpGet]
        public async Task<ActionResult> AllFuelsInTime(RangeModel dataRange)
        {
            var dataSource = await DataService.GetAsync(Server.MapPath("~/App_Data/fuels.csv"), dataRange.MinValue, dataRange.MaxValue);
            ViewData["fuels"] = dataSource;
            ViewData["functionName"] = "chartFunction";
            return PartialView("AllFuelsInTime");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
    }
}