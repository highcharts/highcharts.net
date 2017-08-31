using EnergyApplication.Services;
using System.Web.Mvc;

namespace EnergyApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var dataSource = DataService.Get(Server.MapPath("~/App_Data/fuels.csv"));
            ViewData["fuels"] = dataSource;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
    }
}