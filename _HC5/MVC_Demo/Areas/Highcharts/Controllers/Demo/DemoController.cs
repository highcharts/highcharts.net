using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;
using System.IO;

namespace MVC_Demo.Areas.Highcharts.Controllers.Demo
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

            //DirectoryInfo di = new DirectoryInfo(Server.MapPath("~/Areas/Highcharts/Controllers/Shared/"));

            //foreach (FileInfo fi in di.GetFiles())
            //{
            //    fi.CopyTo(Server.MapPath("~/Content/Areas/Highcharts/Controllers/Shared/") + fi.Name + ".txt");
            //}

            return View("~/Areas/Highcharts/Views/Demo/Index.cshtml");
        }

        public ActionResult Index2(string theme)
        {
            SetViewBag(String.Empty, theme);

            return View("~/Areas/Highcharts/Views/Demo/Index2.cshtml");
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

            string text = System.IO.File.ReadAllText(Server.MapPath("~/Content/Areas/Highcharts/Controllers/Shared/" + demo + "Controller.cs.txt"));
            ViewBag.ControllerCode = text;

            text = System.IO.File.ReadAllText(Server.MapPath("~/Areas/Highcharts/Views/Shared/" + demo + ".cshtml"));
            ViewBag.ViewCode = text;

            switch(demo)
            {
                //line charts
                case "LineBasic":
                    ViewBag.Title = "Basic line";
                    break;
                case "LineAjax":
                    ViewBag.Title = "Ajax loaded data, clickable points";
                    break;
                case "LineLabels":
                    ViewBag.Title = "With data labels";
                    break;
                case "LineTimeSeries":
                    ViewBag.Title = "Time series, zoomable";
                    break;
                case "SplineInverted":
                    ViewBag.Title = "Spline with inverted axes";
                    break;
                case "SplineSymbols":
                    ViewBag.Title = "Spline with symbols";
                    break;
                case "SplinePlotBands":
                    ViewBag.Title = "Spline with plot bands";
                    break;
                case "SplineIrregularTime":
                    ViewBag.Title = "Time data with irregular intervals";
                    break;
                case "LineLogAxis":
                    ViewBag.Title = "Logarithmic axis";
                    break;

                //area charts
                case "AreaBasic":
                    ViewBag.Title = "Basic area";
                    break;
                case "AreaNegative":
                    ViewBag.Title = "Area with negative values";
                    break;
                case "AreaStacked":
                    ViewBag.Title = "Stacked area";
                    break;
                case "AreaStackedPercent":
                    ViewBag.Title = "Percentage area";
                    break;
                case "AreaMissing":
                    ViewBag.Title = "Area with missing points";
                    break;
                case "AreaInverted":
                    ViewBag.Title = "Inverted axes";
                    break;
                case "Areaspline":
                    ViewBag.Title = "Area-spline";
                    break;
                case "Arearange":
                    ViewBag.Title = "Area range";
                    break;
                case "ArearangeLine":
                    ViewBag.Title = "Area range and line";
                    break;
                case "Sparkline":
                    ViewBag.Title = "Sparkline charts";
                    break;

                //column and bar charts
                case "BarBasic":
                    ViewBag.Title = "Basic bar";
                    break;
                case "BarStacked":
                    ViewBag.Title = "Stacked bar";
                    break;
                case "BarNegativeStack":
                    ViewBag.Title = "Bar with negative stack";
                    break;
                case "ColumnBasic":
                    ViewBag.Title = "Basic column";
                    break;
                case "ColumnNegative":
                    ViewBag.Title = "Column with negative values";
                    break;
                case "ColumnStacked":
                    ViewBag.Title = "Stacked column";
                    break;
                case "ColumnStackedAndGrouped":
                    ViewBag.Title = "Stacked and grouped column";
                    break;
                case "ColumnStackedPercent":
                    ViewBag.Title = "Stacked percentage column";
                    break;
                case "ColumnRotatedLabels":
                    ViewBag.Title = "Column with rotated labels";
                    break;
                case "ColumnDrilldown":
                    ViewBag.Title = "Column with drilldown";
                    break;
                case "ColumnPlacement":
                    ViewBag.Title = "Fixed placement columns";
                    break;
                case "ColumnParsed":
                    ViewBag.Title = "Data defined in a HTML table";
                    break;
                case "Columnrange":
                    ViewBag.Title = "Column range";
                    break;

                //Pie charts
                case "PieBasic":
                    ViewBag.Title = "Pie chart";
                    break;
                case "PieLegend":
                    ViewBag.Title = "Pie with legend";
                    break;
                case "PieDonut":
                    ViewBag.Title = "Donut chart";
                    break;
                case "PieSemiCircle":
                    ViewBag.Title = "Semi circle donut";
                    break;
                case "PieDrilldown":
                    ViewBag.Title = "Pie with drilldown";
                    break;
                case "PieGradient":
                    ViewBag.Title = "Pie with gradient fill";
                    break;
                case "PieMonochrome":
                    ViewBag.Title = "Pie with monochrome fill";
                    break;

                //Scatter and bubble charts
                case "Scatter":
                    ViewBag.Title = "Scatter plot";
                    break;
                case "Bubble":
                    ViewBag.Title = "Bubble chart";
                    break;

                //Dynamic charts
                case "DynamicUpdate":
                    ViewBag.Title = "Spline updating each second";
                    break;
                case "DynamicClickToAdd":
                    ViewBag.Title = "Click to add a point";
                    break;
                case "DynamicMasterDetail":
                    ViewBag.Title = "Master-detail chart";
                    break;

                //Combinations
                case "Combo":
                    ViewBag.Title = "Column, line and pie";
                    break;
                case "ComboDualAxes":
                    ViewBag.Title = "Dual axes, line and column";
                    break;
                case "ComboMultiAxes":
                    ViewBag.Title = "Multiple axes";
                    break;
                
                case "ComboRegression":
                    ViewBag.Title = "Scatter with regression line";
                    break;
                case "ComboMeteogram":
                    ViewBag.Title = "Meteogram";
                    break;
                case "ComboTimeline":
                    ViewBag.Title = "Advanced timeline";
                    break;

                //3d charts
                case "Column3DInteractive":
                    ViewBag.Title = "3D column";
                    break;
                case "Column3DNullValues":
                    ViewBag.Title = "3D column with null and 0 values";
                    break;
                case "Column3DStackingGrouping":
                    ViewBag.Title = "3D column with stacking and grouping";
                    break;
                case "Pie3D":
                    ViewBag.Title = "3D pie";
                    break;
                case "Pie3DDonut":
                    ViewBag.Title = "3D donut";
                    break;


                //Gauges
                case "Heatmap":
                    ViewBag.Title = "Heat map";
                    break;
                case "HeatmapCanvas":
                    ViewBag.Title = "Large heat map";
                    break;
                case "TreemapColoraxis":
                    ViewBag.Title = "Tree map with color axis";
                    break;
                case "TreemapWithLevels":
                    ViewBag.Title = "Tree map with levels";
                    break;
                case "TreemapLargeDataset":
                    ViewBag.Title = "Large tree map";
                    break;

                case "Polar":
                    ViewBag.Title = "Polar chart";
                    break;
                case "PolarSpider":
                    ViewBag.Title = "Spiderweb";
                    break;
                case "PolarWindRose":
                    ViewBag.Title = "Wind rose";
                    break;
                case "BoxPlot":
                    ViewBag.Title = "Box plot";
                    break;
                case "ErrorBar":
                    ViewBag.Title = "Error bar";
                    break;
                case "Waterfall":
                    ViewBag.Title = "Waterfall";
                    break;
                case "Funnel":
                    ViewBag.Title = "Funnel chart";
                    break;
                case "Pyramid":
                    ViewBag.Title = "Pyramid chart";
                    break;
                case "Polygon":
                    ViewBag.Title = "Polygon series";
                    break;
                case "Renderer":
                    ViewBag.Title = "General drawing";
                    break;
            }

            ViewBag.Title += " | Highcharts.NET";

            return View();
        }

        public ActionResult Docs(string section)
        {
            ViewBag.Section = section;

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
            string text = System.IO.File.ReadAllText(Server.MapPath("~/Areas/Highcharts/Views/Shared/" + demo + ".cshtml"));
            ViewBag.ViewCode = text;

            return View();
        }

        public ActionResult ControllerCode(string demo)
        {
            string text = System.IO.File.ReadAllText(Server.MapPath("~/Content/Areas/Highcharts/Controllers/Shared/" + demo + "Controller.cs.txt"));
            ViewBag.ControllerCode = text;

            return View();
        }

        public ActionResult DarkUnica()
        {
            return RedirectToAction("Index", new { id = "dark-unica" });
        }

    }
}
