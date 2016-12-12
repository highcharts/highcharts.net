using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Areas.Highstock.Controllers.Demo
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
            //    fi.CopyTo(Server.MapPath("~/Content/Areas/Highstock/Controllers/Shared/") + fi.Name + ".txt", true);
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

            switch (demo)
            {
                //line charts
                case "BasicLine":
                    ViewBag.Title = "Single line series";
                    break;
                case "CandlestickAndVolume":
                    ViewBag.Title = "Two panes, candlestick and volume";
                    break;
                case "Compare":
                    ViewBag.Title = "Compare multiple series";
                    break;
                case "DataGrouping":
                    ViewBag.Title = "52,000 points with data grouping";
                    break;
                case "LazyLoading":
                    ViewBag.Title = "1,7 million points with async loading";
                    break;
                case "IntradayArea":
                    ViewBag.Title = "Intraday Area";
                    break;
                case "IntradayBreaks":
                    ViewBag.Title = "Intraday with breaks";
                    break;
                case "IntradayCandlestick":
                    ViewBag.Title = "Intraday Candlestick";
                    break;
                case "FlagsGeneral":
                    ViewBag.Title = "Flags marking events";
                    break;
                case "DynamicUpdate":
                    ViewBag.Title = "Dynamically Updated Data";
                    break;
                case "LineMarkers":
                    ViewBag.Title = "Line with markers and shadow";
                    break;
                case "Spline":
                    ViewBag.Title = "Spline";
                    break;
                case "StepLine":
                    ViewBag.Title = "Step line";
                    break;
                case "Area":
                    ViewBag.Title = "Area";
                    break;
                case "Areaspline":
                    ViewBag.Title = "Area spline";
                    break;
                case "Arearange":
                    ViewBag.Title = "Area range";
                    break;
                case "Areasplinerange":
                    ViewBag.Title = "Area spline range";
                    break;
                case "Candlestick":
                    ViewBag.Title = "Candlestick";
                    break;
                case "Ohlc":
                    ViewBag.Title = "OHLC";
                    break;
                case "Column":
                    ViewBag.Title = "Column";
                    break;
                case "Columnrange":
                    ViewBag.Title = "Column range";
                    break;
                case "MarkersOnly":
                    ViewBag.Title = "Point markers only";
                    break;
                case "YaxisPlotlines":
                    ViewBag.Title = "Plot lines on Y axis";
                    break;
                case "YaxisPlotbands":
                    ViewBag.Title = "Plot bands on Y axis";
                    break;
                case "YaxisReversed":
                    ViewBag.Title = "Reversed Y axis";
                    break;
                case "StyledScrollbar":
                    ViewBag.Title = "Styled scrollbar";
                    break;
                case "ScrollbarDisabled":
                    ViewBag.Title = "Disabled scrollbar";
                    break;
                case "NavigatorDisabled":
                    ViewBag.Title = "Disabled navigator";
                    break;
                case "FlagsPlacement":
                    ViewBag.Title = "Flags placement";
                    break;
                case "FlagsShapes":
                    ViewBag.Title = "Flags shapes and colors";
                    break;
            }

            ViewBag.Title += " | Highstock.NET";

                    return View();
        }


        public ActionResult Chart(string demo, string theme)
        {
            ViewBag.Demo = demo;
            ViewBag.Theme = theme;

            SetViewBag(demo, theme);

            return View();
        }

        public ActionResult ViewCode(string demo)
        {
            string text = System.IO.File.ReadAllText(Server.MapPath("~/Areas/Highstock/Views/Shared/" + demo + ".cshtml"));
            ViewBag.ViewCode = text;

            return View();
        }

        public ActionResult ControllerCode(string demo)
        {
            string text = System.IO.File.ReadAllText(Server.MapPath("~/Content/Areas/Highstock/Controllers/Shared/" + demo + "Controller.cs.txt"));
            ViewBag.ControllerCode = text;

            return View();
        }

        public ActionResult DarkUnica()
        {
            return RedirectToAction("Index", new { id = "dark-unica" });
        }

    }
}
