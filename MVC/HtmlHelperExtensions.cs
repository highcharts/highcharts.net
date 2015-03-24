using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Web.Mvc;

namespace HighSoft.Web.Mvc
{
    public static class HtmlHelperExtensions
    {
        public static HighSoftNamespace HighSoft(this HtmlHelper helper) { return new HighSoftNamespace(); }
    }

    public class HighSoftNamespace
    {
        public MvcHtmlString HighCharts(HighCharts chart, string id)
        {
            var renderer = new HighChartsRenderer(chart);

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
