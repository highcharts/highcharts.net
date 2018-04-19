using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts;


namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult Scatter()
        {
            List<ChartPoint> femaleValues = new List<ChartPoint>()
            {
                new ChartPoint(161.2, 51.6), new ChartPoint(167.5, 59.0), new ChartPoint(159.5, 49.2), new ChartPoint(157.0, 63.0), new ChartPoint(155.8, 53.6), 
                new ChartPoint(170.0, 59.0), new ChartPoint(159.1, 47.6), new ChartPoint(166.0, 69.8), new ChartPoint(176.2, 66.8), new ChartPoint(160.2, 75.2), 
                new ChartPoint(172.5, 55.2), new ChartPoint(170.9, 54.2), new ChartPoint(172.9, 62.5), new ChartPoint(153.4, 42.0), new ChartPoint(160.0, 50.0), 
                new ChartPoint(147.2, 49.8), new ChartPoint(168.2, 49.2), new ChartPoint(175.0, 73.2), new ChartPoint(157.0, 47.8), new ChartPoint(167.6, 68.8), 
                new ChartPoint(159.5, 50.6), new ChartPoint(175.0, 82.5), new ChartPoint(166.8, 57.2), new ChartPoint(176.5, 87.8), new ChartPoint(170.2, 72.8), 
                new ChartPoint(174.0, 54.5), new ChartPoint(173.0, 59.8), new ChartPoint(179.9, 67.3), new ChartPoint(170.5, 67.8), new ChartPoint(160.0, 47.0), 
                new ChartPoint(154.4, 46.2), new ChartPoint(162.0, 55.0), new ChartPoint(176.5, 83.0), new ChartPoint(160.0, 54.4), new ChartPoint(152.0, 45.8), 
                new ChartPoint(162.1, 53.6), new ChartPoint(170.0, 73.2), new ChartPoint(160.2, 52.1), new ChartPoint(161.3, 67.9), new ChartPoint(166.4, 56.6), 
                new ChartPoint(168.9, 62.3), new ChartPoint(163.8, 58.5), new ChartPoint(167.6, 54.5), new ChartPoint(160.0, 50.2), new ChartPoint(161.3, 60.3), 
                new ChartPoint(167.6, 58.3), new ChartPoint(165.1, 56.2), new ChartPoint(160.0, 50.2), new ChartPoint(170.0, 72.9), new ChartPoint(157.5, 59.8), 
                new ChartPoint(167.6, 61.0), new ChartPoint(160.7, 69.1), new ChartPoint(163.2, 55.9), new ChartPoint(152.4, 46.5), new ChartPoint(157.5, 54.3), 
                new ChartPoint(168.3, 54.8), new ChartPoint(180.3, 60.7), new ChartPoint(165.5, 60.0), new ChartPoint(165.0, 62.0), new ChartPoint(164.5, 60.3), 
                new ChartPoint(156.0, 52.7), new ChartPoint(160.0, 74.3), new ChartPoint(163.0, 62.0), new ChartPoint(165.7, 73.1), new ChartPoint(161.0, 80.0), 
                new ChartPoint(162.0, 54.7), new ChartPoint(166.0, 53.2), new ChartPoint(174.0, 75.7), new ChartPoint(172.7, 61.1), new ChartPoint(167.6, 55.7), 
                new ChartPoint(151.1, 48.7), new ChartPoint(164.5, 52.3), new ChartPoint(163.5, 50.0), new ChartPoint(152.0, 59.3), new ChartPoint(169.0, 62.5), 
                new ChartPoint(164.0, 55.7), new ChartPoint(161.2, 54.8), new ChartPoint(155.0, 45.9), new ChartPoint(170.0, 70.6), new ChartPoint(176.2, 67.2), 
                new ChartPoint(170.0, 69.4), new ChartPoint(162.5, 58.2), new ChartPoint(170.3, 64.8), new ChartPoint(164.1, 71.6), new ChartPoint(169.5, 52.8), 
                new ChartPoint(163.2, 59.8), new ChartPoint(154.5, 49.0), new ChartPoint(159.8, 50.0), new ChartPoint(173.2, 69.2), new ChartPoint(170.0, 55.9), 
                new ChartPoint(161.4, 63.4), new ChartPoint(169.0, 58.2), new ChartPoint(166.2, 58.6), new ChartPoint(159.4, 45.7), new ChartPoint(162.5, 52.2), 
                new ChartPoint(159.0, 48.6), new ChartPoint(162.8, 57.8), new ChartPoint(159.0, 55.6), new ChartPoint(179.8, 66.8), new ChartPoint(162.9, 59.4), 
                new ChartPoint(161.0, 53.6), new ChartPoint(151.1, 73.2), new ChartPoint(168.2, 53.4), new ChartPoint(168.9, 69.0), new ChartPoint(173.2, 58.4), 
                new ChartPoint(171.8, 56.2), new ChartPoint(178.0, 70.6), new ChartPoint(164.3, 59.8), new ChartPoint(163.0, 72.0), new ChartPoint(168.5, 65.2), 
                new ChartPoint(166.8, 56.6), new ChartPoint(172.7, 105.2), new ChartPoint(163.5, 51.8), new ChartPoint(169.4, 63.4), new ChartPoint(167.8, 59.0), 
                new ChartPoint(159.5, 47.6), new ChartPoint(167.6, 63.0), new ChartPoint(161.2, 55.2), new ChartPoint(160.0, 45.0), new ChartPoint(163.2, 54.0), 
                new ChartPoint(162.2, 50.2), new ChartPoint(161.3, 60.2), new ChartPoint(149.5, 44.8), new ChartPoint(157.5, 58.8), new ChartPoint(163.2, 56.4), 
                new ChartPoint(172.7, 62.0), new ChartPoint(155.0, 49.2), new ChartPoint(156.5, 67.2), new ChartPoint(164.0, 53.8), new ChartPoint(160.9, 54.4), 
                new ChartPoint(162.8, 58.0), new ChartPoint(167.0, 59.8), new ChartPoint(160.0, 54.8), new ChartPoint(160.0, 43.2), new ChartPoint(168.9, 60.5), 
                new ChartPoint(158.2, 46.4), new ChartPoint(156.0, 64.4), new ChartPoint(160.0, 48.8), new ChartPoint(167.1, 62.2), new ChartPoint(158.0, 55.5), 
                new ChartPoint(167.6, 57.8), new ChartPoint(156.0, 54.6), new ChartPoint(162.1, 59.2), new ChartPoint(173.4, 52.7), new ChartPoint(159.8, 53.2), 
                new ChartPoint(170.5, 64.5), new ChartPoint(159.2, 51.8), new ChartPoint(157.5, 56.0), new ChartPoint(161.3, 63.6), new ChartPoint(162.6, 63.2), 
                new ChartPoint(160.0, 59.5), new ChartPoint(168.9, 56.8), new ChartPoint(165.1, 64.1), new ChartPoint(162.6, 50.0), new ChartPoint(165.1, 72.3), 
                new ChartPoint(166.4, 55.0), new ChartPoint(160.0, 55.9), new ChartPoint(152.4, 60.4), new ChartPoint(170.2, 69.1), new ChartPoint(162.6, 84.5), 
                new ChartPoint(170.2, 55.9), new ChartPoint(158.8, 55.5), new ChartPoint(172.7, 69.5), new ChartPoint(167.6, 76.4), new ChartPoint(162.6, 61.4), 
                new ChartPoint(167.6, 65.9), new ChartPoint(156.2, 58.6), new ChartPoint(175.2, 66.8), new ChartPoint(172.1, 56.6), new ChartPoint(162.6, 58.6), 
                new ChartPoint(160.0, 55.9), new ChartPoint(165.1, 59.1), new ChartPoint(182.9, 81.8), new ChartPoint(166.4, 70.7), new ChartPoint(165.1, 56.8), 
                new ChartPoint(177.8, 60.0), new ChartPoint(165.1, 58.2), new ChartPoint(175.3, 72.7), new ChartPoint(154.9, 54.1), new ChartPoint(158.8, 49.1), 
                new ChartPoint(172.7, 75.9), new ChartPoint(168.9, 55.0), new ChartPoint(161.3, 57.3), new ChartPoint(167.6, 55.0), new ChartPoint(165.1, 65.5), 
                new ChartPoint(175.3, 65.5), new ChartPoint(157.5, 48.6), new ChartPoint(163.8, 58.6), new ChartPoint(167.6, 63.6), new ChartPoint(165.1, 55.2), 
                new ChartPoint(165.1, 62.7), new ChartPoint(168.9, 56.6), new ChartPoint(162.6, 53.9), new ChartPoint(164.5, 63.2), new ChartPoint(176.5, 73.6), 
                new ChartPoint(168.9, 62.0), new ChartPoint(175.3, 63.6), new ChartPoint(159.4, 53.2), new ChartPoint(160.0, 53.4), new ChartPoint(170.2, 55.0), 
                new ChartPoint(162.6, 70.5), new ChartPoint(167.6, 54.5), new ChartPoint(162.6, 54.5), new ChartPoint(160.7, 55.9), new ChartPoint(160.0, 59.0), 
                new ChartPoint(157.5, 63.6), new ChartPoint(162.6, 54.5), new ChartPoint(152.4, 47.3), new ChartPoint(170.2, 67.7), new ChartPoint(165.1, 80.9), 
                new ChartPoint(172.7, 70.5), new ChartPoint(165.1, 60.9), new ChartPoint(170.2, 63.6), new ChartPoint(170.2, 54.5), new ChartPoint(170.2, 59.1), 
                new ChartPoint(161.3, 70.5), new ChartPoint(167.6, 52.7), new ChartPoint(167.6, 62.7), new ChartPoint(165.1, 86.3), new ChartPoint(162.6, 66.4), 
                new ChartPoint(152.4, 67.3), new ChartPoint(168.9, 63.0), new ChartPoint(170.2, 73.6), new ChartPoint(175.2, 62.3), new ChartPoint(175.2, 57.7), 
                new ChartPoint(160.0, 55.4), new ChartPoint(165.1, 104.1), new ChartPoint(174.0, 55.5), new ChartPoint(170.2, 77.3), new ChartPoint(160.0, 80.5), 
                new ChartPoint(167.6, 64.5), new ChartPoint(167.6, 72.3), new ChartPoint(167.6, 61.4), new ChartPoint(154.9, 58.2), new ChartPoint(162.6, 81.8), 
                new ChartPoint(175.3, 63.6), new ChartPoint(171.4, 53.4), new ChartPoint(157.5, 54.5), new ChartPoint(165.1, 53.6), new ChartPoint(160.0, 60.0), 
                new ChartPoint(174.0, 73.6), new ChartPoint(162.6, 61.4), new ChartPoint(174.0, 55.5), new ChartPoint(162.6, 63.6), new ChartPoint(161.3, 60.9), 
                new ChartPoint(156.2, 60.0), new ChartPoint(149.9, 46.8), new ChartPoint(169.5, 57.3), new ChartPoint(160.0, 64.1), new ChartPoint(175.3, 63.6), 
                new ChartPoint(169.5, 67.3), new ChartPoint(160.0, 75.5), new ChartPoint(172.7, 68.2), new ChartPoint(162.6, 61.4), new ChartPoint(157.5, 76.8), 
                new ChartPoint(176.5, 71.8), new ChartPoint(164.4, 55.5), new ChartPoint(160.7, 48.6), new ChartPoint(174.0, 66.4), new ChartPoint(163.8, 67.3)
            };


            List<ChartPoint> maleValues = new List<ChartPoint>()
            {
                new ChartPoint(174.0, 65.6), new ChartPoint(175.3, 71.8), new ChartPoint(193.5, 80.7), new ChartPoint(186.5, 72.6), new ChartPoint(187.2, 78.8), 
                new ChartPoint(181.5, 74.8), new ChartPoint(184.0, 86.4), new ChartPoint(184.5, 78.4), new ChartPoint(175.0, 62.0), new ChartPoint(184.0, 81.6), 
                new ChartPoint(180.0, 76.6), new ChartPoint(177.8, 83.6), new ChartPoint(192.0, 90.0), new ChartPoint(176.0, 74.6), new ChartPoint(174.0, 71.0), 
                new ChartPoint(184.0, 79.6), new ChartPoint(192.7, 93.8), new ChartPoint(171.5, 70.0), new ChartPoint(173.0, 72.4), new ChartPoint(176.0, 85.9), 
                new ChartPoint(176.0, 78.8), new ChartPoint(180.5, 77.8), new ChartPoint(172.7, 66.2), new ChartPoint(176.0, 86.4), new ChartPoint(173.5, 81.8), 
                new ChartPoint(178.0, 89.6), new ChartPoint(180.3, 82.8), new ChartPoint(180.3, 76.4), new ChartPoint(164.5, 63.2), new ChartPoint(173.0, 60.9), 
                new ChartPoint(183.5, 74.8), new ChartPoint(175.5, 70.0), new ChartPoint(188.0, 72.4), new ChartPoint(189.2, 84.1), new ChartPoint(172.8, 69.1), 
                new ChartPoint(170.0, 59.5), new ChartPoint(182.0, 67.2), new ChartPoint(170.0, 61.3), new ChartPoint(177.8, 68.6), new ChartPoint(184.2, 80.1), 
                new ChartPoint(186.7, 87.8), new ChartPoint(171.4, 84.7), new ChartPoint(172.7, 73.4), new ChartPoint(175.3, 72.1), new ChartPoint(180.3, 82.6), 
                new ChartPoint(182.9, 88.7), new ChartPoint(188.0, 84.1), new ChartPoint(177.2, 94.1), new ChartPoint(172.1, 74.9), new ChartPoint(167.0, 59.1), 
                new ChartPoint(169.5, 75.6), new ChartPoint(174.0, 86.2), new ChartPoint(172.7, 75.3), new ChartPoint(182.2, 87.1), new ChartPoint(164.1, 55.2), 
                new ChartPoint(163.0, 57.0), new ChartPoint(171.5, 61.4), new ChartPoint(184.2, 76.8), new ChartPoint(174.0, 86.8), new ChartPoint(174.0, 72.2), 
                new ChartPoint(177.0, 71.6), new ChartPoint(186.0, 84.8), new ChartPoint(167.0, 68.2), new ChartPoint(171.8, 66.1), new ChartPoint(182.0, 72.0), 
                new ChartPoint(167.0, 64.6), new ChartPoint(177.8, 74.8), new ChartPoint(164.5, 70.0), new ChartPoint(192.0, 101.6), new ChartPoint(175.5, 63.2), 
                new ChartPoint(171.2, 79.1), new ChartPoint(181.6, 78.9), new ChartPoint(167.4, 67.7), new ChartPoint(181.1, 66.0), new ChartPoint(177.0, 68.2), 
                new ChartPoint(174.5, 63.9), new ChartPoint(177.5, 72.0), new ChartPoint(170.5, 56.8), new ChartPoint(182.4, 74.5), new ChartPoint(197.1, 90.9), 
                new ChartPoint(180.1, 93.0), new ChartPoint(175.5, 80.9), new ChartPoint(180.6, 72.7), new ChartPoint(184.4, 68.0), new ChartPoint(175.5, 70.9), 
                new ChartPoint(180.6, 72.5), new ChartPoint(177.0, 72.5), new ChartPoint(177.1, 83.4), new ChartPoint(181.6, 75.5), new ChartPoint(176.5, 73.0), 
                new ChartPoint(175.0, 70.2), new ChartPoint(174.0, 73.4), new ChartPoint(165.1, 70.5), new ChartPoint(177.0, 68.9), new ChartPoint(192.0, 102.3), 
                new ChartPoint(176.5, 68.4), new ChartPoint(169.4, 65.9), new ChartPoint(182.1, 75.7), new ChartPoint(179.8, 84.5), new ChartPoint(175.3, 87.7), 
                new ChartPoint(184.9, 86.4), new ChartPoint(177.3, 73.2), new ChartPoint(167.4, 53.9), new ChartPoint(178.1, 72.0), new ChartPoint(168.9, 55.5), 
                new ChartPoint(157.2, 58.4), new ChartPoint(180.3, 83.2), new ChartPoint(170.2, 72.7), new ChartPoint(177.8, 64.1), new ChartPoint(172.7, 72.3), 
                new ChartPoint(165.1, 65.0), new ChartPoint(186.7, 86.4), new ChartPoint(165.1, 65.0), new ChartPoint(174.0, 88.6), new ChartPoint(175.3, 84.1), 
                new ChartPoint(185.4, 66.8), new ChartPoint(177.8, 75.5), new ChartPoint(180.3, 93.2), new ChartPoint(180.3, 82.7), new ChartPoint(177.8, 58.0), 
                new ChartPoint(177.8, 79.5), new ChartPoint(177.8, 78.6), new ChartPoint(177.8, 71.8), new ChartPoint(177.8, 116.4), new ChartPoint(163.8, 72.2), 
                new ChartPoint(188.0, 83.6), new ChartPoint(198.1, 85.5), new ChartPoint(175.3, 90.9), new ChartPoint(166.4, 85.9), new ChartPoint(190.5, 89.1), 
                new ChartPoint(166.4, 75.0), new ChartPoint(177.8, 77.7), new ChartPoint(179.7, 86.4), new ChartPoint(172.7, 90.9), new ChartPoint(190.5, 73.6), 
                new ChartPoint(185.4, 76.4), new ChartPoint(168.9, 69.1), new ChartPoint(167.6, 84.5), new ChartPoint(175.3, 64.5), new ChartPoint(170.2, 69.1), 
                new ChartPoint(190.5, 108.6), new ChartPoint(177.8, 86.4), new ChartPoint(190.5, 80.9), new ChartPoint(177.8, 87.7), new ChartPoint(184.2, 94.5), 
                new ChartPoint(176.5, 80.2), new ChartPoint(177.8, 72.0), new ChartPoint(180.3, 71.4), new ChartPoint(171.4, 72.7), new ChartPoint(172.7, 84.1), 
                new ChartPoint(172.7, 76.8), new ChartPoint(177.8, 63.6), new ChartPoint(177.8, 80.9), new ChartPoint(182.9, 80.9), new ChartPoint(170.2, 85.5), 
                new ChartPoint(167.6, 68.6), new ChartPoint(175.3, 67.7), new ChartPoint(165.1, 66.4), new ChartPoint(185.4, 102.3), new ChartPoint(181.6, 70.5), 
                new ChartPoint(172.7, 95.9), new ChartPoint(190.5, 84.1), new ChartPoint(179.1, 87.3), new ChartPoint(175.3, 71.8), new ChartPoint(170.2, 65.9), 
                new ChartPoint(193.0, 95.9), new ChartPoint(171.4, 91.4), new ChartPoint(177.8, 81.8), new ChartPoint(177.8, 96.8), new ChartPoint(167.6, 69.1), 
                new ChartPoint(167.6, 82.7), new ChartPoint(180.3, 75.5), new ChartPoint(182.9, 79.5), new ChartPoint(176.5, 73.6), new ChartPoint(186.7, 91.8), 
                new ChartPoint(188.0, 84.1), new ChartPoint(188.0, 85.9), new ChartPoint(177.8, 81.8), new ChartPoint(174.0, 82.5), new ChartPoint(177.8, 80.5), 
                new ChartPoint(171.4, 70.0), new ChartPoint(185.4, 81.8), new ChartPoint(185.4, 84.1), new ChartPoint(188.0, 90.5), new ChartPoint(188.0, 91.4), 
                new ChartPoint(182.9, 89.1), new ChartPoint(176.5, 85.0), new ChartPoint(175.3, 69.1), new ChartPoint(175.3, 73.6), new ChartPoint(188.0, 80.5), 
                new ChartPoint(188.0, 82.7), new ChartPoint(175.3, 86.4), new ChartPoint(170.5, 67.7), new ChartPoint(179.1, 92.7), new ChartPoint(177.8, 93.6), 
                new ChartPoint(175.3, 70.9), new ChartPoint(182.9, 75.0), new ChartPoint(170.8, 93.2), new ChartPoint(188.0, 93.2), new ChartPoint(180.3, 77.7), 
                new ChartPoint(177.8, 61.4), new ChartPoint(185.4, 94.1), new ChartPoint(168.9, 75.0), new ChartPoint(185.4, 83.6), new ChartPoint(180.3, 85.5), 
                new ChartPoint(174.0, 73.9), new ChartPoint(167.6, 66.8), new ChartPoint(182.9, 87.3), new ChartPoint(160.0, 72.3), new ChartPoint(180.3, 88.6), 
                new ChartPoint(167.6, 75.5), new ChartPoint(186.7, 101.4), new ChartPoint(175.3, 91.1), new ChartPoint(175.3, 67.3), new ChartPoint(175.9, 77.7), 
                new ChartPoint(175.3, 81.8), new ChartPoint(179.1, 75.5), new ChartPoint(181.6, 84.5), new ChartPoint(177.8, 76.6), new ChartPoint(182.9, 85.0), 
                new ChartPoint(177.8, 102.5), new ChartPoint(184.2, 77.3), new ChartPoint(179.1, 71.8), new ChartPoint(176.5, 87.9), new ChartPoint(188.0, 94.3), 
                new ChartPoint(174.0, 70.9), new ChartPoint(167.6, 64.5), new ChartPoint(170.2, 77.3), new ChartPoint(167.6, 72.3), new ChartPoint(188.0, 87.3), 
                new ChartPoint(174.0, 80.0), new ChartPoint(176.5, 82.3), new ChartPoint(180.3, 73.6), new ChartPoint(167.6, 74.1), new ChartPoint(188.0, 85.9), 
                new ChartPoint(180.3, 73.2), new ChartPoint(167.6, 76.3), new ChartPoint(183.0, 65.9), new ChartPoint(183.0, 90.9), new ChartPoint(179.1, 89.1), 
                new ChartPoint(170.2, 62.3), new ChartPoint(177.8, 82.7), new ChartPoint(179.1, 79.1), new ChartPoint(190.5, 98.2), new ChartPoint(177.8, 84.1), 
                new ChartPoint(180.3, 83.2), new ChartPoint(180.3, 83.2)
            };

            List<ScatterSeriesData> femaleData = new List<ScatterSeriesData>();
            List<ScatterSeriesData> maleData = new List<ScatterSeriesData>();

            femaleValues.ForEach(p => femaleData.Add(new ScatterSeriesData { X = p.X, Y = p.Y }));
            maleValues.ForEach(p => maleData.Add(new ScatterSeriesData { X = p.X, Y = p.Y }));

            ViewData["femaleData"] = femaleData;
            ViewData["maleData"] = maleData;

            return View();
        }

        private class ChartPoint
        {
            public ChartPoint(double? x, double? y)
            {
                X = x;
                Y = y;
            }
            public double? X { get; set; }
            public double? Y { get; set; }
        }
    }
}
