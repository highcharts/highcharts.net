using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Highstock_Demo.Areas.Highstock.Controllers.Demo
{
    public class DemoController : Controller
    {
        private void SetViewBag(string demo, string theme)
        {
            if (String.IsNullOrEmpty(theme))
                ViewBag.Theme = "default";
            else
                ViewBag.Theme = theme;

            switch (theme)
            {
                case "dark-unica":
                    ViewBag.DarkUnicaDisabled = "disabled";
                    ViewBag.ChartImageSVG = "dark-unica.png";
                    ViewBag.ChartImagePNG = "dark-unica.png";
                    ViewBag.ImageContainer = "dark-unica";
                    break;
                case "sand-signika":
                    ViewBag.SandSignikaDisabled = "disabled";
                    ViewBag.ChartImageSVG = "sand-signika.svg";
                    ViewBag.ChartImagePNG = "sand-signika.png";
                    ViewBag.ImageContainer = "sand-signika";
                    break;
                case "grid-light":
                    ViewBag.GridLightDisabled = "disabled";
                    ViewBag.ChartImageSVG = "grid-light.png";
                    ViewBag.ChartImagePNG = "grid-light.png";
                    ViewBag.ImageContainer = "grid-light";
                    break;
                default:
                    ViewBag.DefaultDisabled = "disabled";
                    ViewBag.ChartImageSVG = "default.svg";
                    ViewBag.ChartImagePNG = "default.png";
                    ViewBag.ImageContainer = "default";
                    break;
            }
        }

        public ActionResult Index(string theme)
        {
            SetViewBag(String.Empty, theme);

            
            //Code to copy the controllers from the code directory to a .txt format - needed for Beanstalk
            
            //DirectoryInfo di = new DirectoryInfo(Server.MapPath("~/Areas/Highstock/Controllers/Shared/"));
            //foreach (FileInfo fi in di.GetFiles())
            //{
            //    fi.CopyTo(Server.MapPath("~/Content/Areas/Highstock/Controllers/Shared/") + fi.Name + ".txt");
            //}

            return View("~/Areas/Highstock/Views/Demo/Index.cshtml");
        }

        public ActionResult Help()
        {
            return View();
        }

        public ActionResult Gallery(string demo, string theme)
        {
            ViewBag.Demo = demo;
            ViewBag.Theme = theme;

            SetViewBag(demo, theme);

            string text = System.IO.File.ReadAllText(Server.MapPath("~/Content/Areas/Highstock/Controllers/Shared/" + demo + "Controller.cs.txt"));
            ViewBag.ControllerCode = text;

            text = System.IO.File.ReadAllText(Server.MapPath("~/Areas/Highstock/Views/Shared/" + demo + ".cshtml"));
            ViewBag.ViewCode = text;

            return View();
        }

        public ActionResult DarkUnica()
        {
            return RedirectToAction("Index", new { id = "dark-unica" });
        }

    }
}
