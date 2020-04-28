using Highsoft.Web.Mvc.Stocks;
using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

namespace MVC_Demo.Areas.Highstock.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult LineMarkers()
        {
            List<LineSeriesData> companyDatas = new List<LineSeriesData>();

            foreach (PointData data in LineMarkersGetList())
            {
                companyDatas.Add(new LineSeriesData
                {
                    X = Convert.ToDouble(data.Date),
                    Y = Convert.ToDouble(data.Value)
                });
            }

            ViewBag.AppleData = companyDatas.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }



        private List<PointData> LineMarkersGetList()
        {
            string url = "https://www.highcharts.com/samples/data/jsonp.php?filename=aapl-c.json&callback=";
            string json;

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(url);
            }

            json = json.Substring(json.IndexOf('[') + 1);
            json = json.Substring(json.IndexOf('[') + 1);

            List<PointData> AppleDatas = new List<PointData>();


            while (true)
            {
                if (json.IndexOf('[') == -1)
                    break;

                string entity = json.Substring(0, json.IndexOf(']'));
                string[] values = entity.Split(',');

                AppleDatas.Add(
                    new PointData
                    {
                        Date = Convert.ToDouble(values[0], CultureInfo.InvariantCulture),
                        Value = Convert.ToDouble(values[1], CultureInfo.InvariantCulture)
                    }
                );

                json = json.Substring(json.IndexOf('[') + 1);
            }

            return AppleDatas;
        }
    }
}
