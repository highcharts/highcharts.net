using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc;
using System.IO;

namespace MVC_Demo.Areas.Highcharts.Controllers.Demo
{
    public class DemoController : Controller
    {
        public ActionResult Index(string id, string theme)
        {
            string defaultSVG = "default.svg";
            string defaultPNG = "default.png";
            string darkUnicaPNG = "dark-unica.png";

            switch (theme)
            {
                case "dark-unica": 
                    ViewBag.DarkUnicaDisabled = "disabled";
                    ViewBag.ChartImageSVG = darkUnicaPNG;
                    ViewBag.ChartImagePNG = darkUnicaPNG;
                    ViewBag.ImageContainer = "dark-unica";                    
                    break;
                case "sand-signika": ViewBag.SandSignikaDisabled = "disabled"; break;
                case "grid-light": ViewBag.GridLightDisabled = "disabled"; break;
                default: 
                    ViewBag.DefaultDisabled = "disabled"; 
                    ViewBag.ChartImageSVG = defaultSVG;
                    ViewBag.ChartImagePNG = defaultPNG;
                    ViewBag.ImageContainer = "default";
                    break;
            }


            id = String.IsNullOrEmpty(id) ? id = "default.svg" : String.Format("{0}.png", id);


            ViewData["theme"] = id;
            return View();
        }

        public ActionResult Gallery(string demo)
        {
            ViewBag.Demo = demo;

            string text = System.IO.File.ReadAllText(Server.MapPath("~/Areas/Highcharts/Controllers/Shared/" + demo + "Controller.cs"));
            ViewBag.ControllerCode = text;

            text = System.IO.File.ReadAllText(Server.MapPath("~/Areas/Highcharts/Views/Shared/" + demo + ".cshtml"));
            ViewBag.ViewCode = text;

            return View();
        }

        public ActionResult DarkUnica()
        {
            return RedirectToAction("Index", new { id = "dark-unica" });
        }

    }
}
