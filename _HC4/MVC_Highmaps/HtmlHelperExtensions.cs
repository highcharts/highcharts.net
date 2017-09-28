using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Maps.Rendering;
//using Highsoft.Web.Mvc.Charts;

namespace Highsoft.Web.Mvc.Maps
{
    public static class HtmlHelperExtensions
    {
        public static HighsoftNamespace Highsoft(this HtmlHelper helper) { return new HighsoftNamespace(); }

        public static MvcHtmlString Highmaps(Highmaps map, string id)
        {
            var renderer = new HighmapsRenderer(map);

            map.ID = id;
            map.Chart.RenderTo = id;

            return MvcHtmlString.Create(renderer.RenderHtml());
        }
    }

    public class HighsoftNamespace
    {
        public MvcHtmlString Highmaps(Highmaps chart, string id)
        {            
            var renderer = new HighmapsRenderer(chart);  
            
            chart.ID = id;
            chart.Chart.RenderTo = id;
            
            return MvcHtmlString.Create(renderer.RenderHtml());
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        new bool Equals(object value) { return base.Equals(value); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        new int GetHashCode() { return base.GetHashCode(); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        new Type GetType() { return base.GetType(); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        new string ToString() { return base.ToString(); }
    }    
}
