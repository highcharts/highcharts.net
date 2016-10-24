using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Stocks;
using Highsoft.Web.Mvc.Stocks.Rendering;

namespace Highsoft.Web.Mvc.Stocks
{
    public static class HtmlHelperExtensions
    {
        public static HighsoftNamespace Highsoft(this HtmlHelper helper) { return new HighsoftNamespace(); }
    }

    public class HighsoftNamespace
    {
        public MvcHtmlString Highstock(Highstock chart, string id)
        {            
            var renderer = new HighstockRenderer(chart);  
            
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
