using Highsoft.Web.Mvc.Stocks;
using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Areas.Highstock.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult CandlestickAndVolume()
        {
            List<CandleStickSeriesData> appleData = new List<CandleStickSeriesData>();
            List<ColumnSeriesData> volumeData = new List<ColumnSeriesData>();
            List<LineSeriesData> navigatorData = new List<LineSeriesData>();

            foreach (CandlestickVolume volume in DataReceiver.GetJSONCandlestickVolumes())
            {
                appleData.Add(new CandleStickSeriesData
                {
                    Open = Convert.ToDouble(volume.Open),
                    High = Convert.ToDouble(volume.High),
                    Low = Convert.ToDouble(volume.Low),
                    Close = Convert.ToDouble(volume.Close),
                    X = Convert.ToDouble(volume.Date)
                });

                volumeData.Add(new ColumnSeriesData
                {
                    X = Convert.ToDouble(volume.Date),
                    Y = Convert.ToDouble(volume.Volume)
                });

                //navigatorData.Add(new LineSeriesData
                //{
                //    X = Convert.ToDouble(volume.Date),
                //    Y = Convert.ToDouble(volume.Close)
                //});
            }


            ViewBag.AppleData = appleData.OrderBy(o => o.X).ToList();
            ViewBag.VolumeData = volumeData.OrderBy(o => o.X).ToList();
            //ViewBag.NavigatorData = navigatorData.OrderBy(o => o.X).ToList();

            return View(ViewBag);
        }
    }
}
