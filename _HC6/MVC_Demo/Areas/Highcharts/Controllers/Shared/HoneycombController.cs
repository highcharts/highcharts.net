using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Highsoft.Web.Mvc.Charts;
using System.Web.Mvc;

namespace MVC_Demo.Areas.Highcharts.Controllers.Shared
{
    public partial class SharedController : Controller
    {
        public ActionResult Honeycomb()
        {
            List<TilemapSeriesData> list = new List<TilemapSeriesData>();
            list.Add(new TilemapSeriesData { Id = "AL", Name = "Alabama", X = 6, Y = 7, Value = 4849377 });
            list.Add(new TilemapSeriesData { Id = "AK", Name = "Alaska", X = 0, Y = 0, Value = 737732 });
            list.Add(new TilemapSeriesData { Id = "AZ", Name = "Arizona", X = 5, Y = 3, Value = 6745408 });
            list.Add(new TilemapSeriesData { Id = "AR", Name = "Arkansas", X = 5, Y = 6, Value = 2994079 });
            list.Add(new TilemapSeriesData { Id = "CA", Name = "California", X = 5, Y = 2, Value = 39250017 });
            list.Add(new TilemapSeriesData { Id = "CO", Name = "Colorado", X = 4, Y = 3, Value = 5540545 });
            list.Add(new TilemapSeriesData { Id = "CT", Name = "Connecticat", X = 3, Y = 11, Value = 3596677 });
            list.Add(new TilemapSeriesData { Id = "DE", Name = "Delaware", X = 4, Y = 9, Value = 935614 });
            list.Add(new TilemapSeriesData { Id = "DC", Name = "District of Columbia", X = 4, Y = 10, Value = 7288000 });
            list.Add(new TilemapSeriesData { Id = "FL", Name = "Florida", X = 8, Y = 8, Value = 20612439 });
            list.Add(new TilemapSeriesData { Id = "GA", Name = "Georgia", X = 7, Y = 8, Value = 10310371 });
            list.Add(new TilemapSeriesData { Id = "HI", Name = "Hawaii", X = 8, Y = 0, Value = 1419561 });
            list.Add(new TilemapSeriesData { Id = "ID", Name = "Idaho", X = 3, Y = 2, Value = 1634464 });
            list.Add(new TilemapSeriesData { Id = "IL", Name = "Illinois", X = 3, Y = 6, Value = 12801539 });
            list.Add(new TilemapSeriesData { Id = "IN", Name = "Indiana", X = 3, Y = 7, Value = 6596855 });
            list.Add(new TilemapSeriesData { Id = "IA", Name = "Iowa", X = 3, Y = 5, Value = 3107126 });
            list.Add(new TilemapSeriesData { Id = "KS", Name = "Kansas", X = 5, Y = 5, Value = 2904021 });
            list.Add(new TilemapSeriesData { Id = "KY", Name = "Kentucky", X = 4, Y = 6, Value = 4413457 });
            list.Add(new TilemapSeriesData { Id = "LA", Name = "Louisiana", X = 6, Y = 5, Value = 4649676 });
            list.Add(new TilemapSeriesData { Id = "ME", Name = "Maine", X = 0, Y = 11, Value = 1330089 });
            list.Add(new TilemapSeriesData { Id = "MD", Name = "Maryland", X = 4, Y = 8, Value = 6016447 });
            list.Add(new TilemapSeriesData { Id = "MA", Name = "Massachusetts", X = 2, Y = 10, Value = 6811779 });
            list.Add(new TilemapSeriesData { Id = "MI", Name = "Michigan", X = 2, Y = 7, Value = 9928301 });
            list.Add(new TilemapSeriesData { Id = "MN", Name = "Minnesota", X = 2, Y = 4, Value = 5519952 });
            list.Add(new TilemapSeriesData { Id = "MS", Name = "Mississippi", X = 6, Y = 6, Value = 2984926 });
            list.Add(new TilemapSeriesData { Id = "MO", Name = "Missouri", X = 4, Y = 5, Value = 6093000 });
            list.Add(new TilemapSeriesData { Id = "MT", Name = "Montana", X = 2, Y = 2, Value = 1023579 });
            list.Add(new TilemapSeriesData { Id = "NE", Name = "Nebraska", X = 4, Y = 4, Value = 1881503 });
            list.Add(new TilemapSeriesData { Id = "NV", Name = "Nevada", X = 4, Y = 2, Value = 2839099 });
            list.Add(new TilemapSeriesData { Id = "NH", Name = "New Hampshire", X = 1, Y = 11, Value = 1326813 });
            list.Add(new TilemapSeriesData { Id = "NJ", Name = "New Jersey", X = 3, Y = 10, Value = 8944469 });
            list.Add(new TilemapSeriesData { Id = "NM", Name = "New Mexico", X = 6, Y = 3, Value = 2085572 });
            list.Add(new TilemapSeriesData { Id = "NY", Name = "New York", X = 2, Y = 9, Value = 19745289 });
            list.Add(new TilemapSeriesData { Id = "NC", Name = "North Carolina", X = 5, Y = 9, Value = 10146788 });
            list.Add(new TilemapSeriesData { Id = "ND", Name = "North Dakota", X = 2, Y = 3, Value = 739482 });
            list.Add(new TilemapSeriesData { Id = "OH", Name = "Ohio", X = 3, Y = 8, Value = 11614373 });
            list.Add(new TilemapSeriesData { Id = "OK", Name = "Oklahoma", X = 6, Y = 4, Value = 3878051 });
            list.Add(new TilemapSeriesData { Id = "OR", Name = "Oregon", X = 4, Y = 1, Value = 3970239 });
            list.Add(new TilemapSeriesData { Id = "PA", Name = "Pennsylvania", X = 3, Y = 9, Value = 12784227 });
            list.Add(new TilemapSeriesData { Id = "RI", Name = "Rhode Island", X = 2, Y = 11, Value = 1055173 });
            list.Add(new TilemapSeriesData { Id = "SC", Name = "South Carolina", X = 6, Y = 8, Value = 4832482 });
            list.Add(new TilemapSeriesData { Id = "SD", Name = "South Dakota", X = 3, Y = 4, Value = 853175 });
            list.Add(new TilemapSeriesData { Id = "TN", Name = "Tennessee", X = 5, Y = 7, Value = 6651194 });
            list.Add(new TilemapSeriesData { Id = "TX", Name = "Texas", X = 7, Y = 4, Value = 27862596 });
            list.Add(new TilemapSeriesData { Id = "UT", Name = "Utah", X = 5, Y = 4, Value = 2942902 });
            list.Add(new TilemapSeriesData { Id = "VT", Name = "Vermont", X = 1, Y = 10, Value = 626011 });
            list.Add(new TilemapSeriesData { Id = "VA", Name = "Virginia", X = 5, Y = 8, Value = 8411808 });
            list.Add(new TilemapSeriesData { Id = "WA", Name = "Washington", X = 2, Y = 1, Value = 7288000 });
            list.Add(new TilemapSeriesData { Id = "WV", Name = "West Virginia", X = 4, Y = 7, Value = 1850326 });
            list.Add(new TilemapSeriesData { Id = "WI", Name = "Wisconsin", X = 2, Y = 5, Value = 5778708 });
            list.Add(new TilemapSeriesData { Id = "WY", Name = "Wyoming", X = 3, Y = 3, Value = 584153 });

            ViewData["Data"] = list;

            return View();
        }

    }
}
