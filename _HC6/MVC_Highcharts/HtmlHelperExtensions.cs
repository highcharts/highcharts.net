using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts.Rendering;
using Highsoft.Web.Mvc.Charts;

namespace Highsoft.Web.Mvc.Charts
{
    public static class HtmlHelperExtensions
    {
        public static HighsoftNamespace Highsoft(this HtmlHelper helper) { return new HighsoftNamespace(); }

        [Obsolete("Use HighsoftNamespace.GetHighcharts or HighsoftNamespace.Highcharts instead.")]
        public static MvcHtmlString Highcharts(Highcharts chart, string containerId)
        {
            var renderer = new HighchartsRenderer(chart);

            if (!string.IsNullOrWhiteSpace(containerId))
            {
                chart.ID = containerId;
            }

            return MvcHtmlString.Create(renderer.RenderHtml());
        }
    }

    public class HighsoftNamespace
    {
        public MvcHtmlString Highcharts(Highcharts chart, string containerId)
        {            
            var renderer = new HighchartsRenderer(chart);
            AssignContainerId(chart, containerId);

            return MvcHtmlString.Create(renderer.RenderHtml());
        }

        public HtmlString GetHighcharts(Highcharts chart, string containerId, bool addContainer = true, string functionName = null)
        {
            if (functionName != null)
                return GetHighchartsFunction(chart, containerId, functionName);

            var renderer = new HighchartsRenderer(chart);
            AssignContainerId(chart, containerId);

            if(addContainer)
                return new HtmlString(renderer.RenderHtml());

            return new HtmlString(renderer.RenderHtml(addContainer));
        }

        public HtmlString GetHighchartsJS(Highcharts chart, string containerId)
        {
            var renderer = new HighchartsRenderer(chart);
            AssignContainerId(chart, containerId);

            return new HtmlString(renderer.GetJavascript());
        }

        private HtmlString GetHighchartsFunction(Highcharts chart, string containerId, string functionName)
        {
            var renderer = new HighchartsRenderer(chart);
            AssignContainerId(chart, containerId);

            return new HtmlString(renderer.GetJavascriptFunction(functionName));
        }

        private void AssignContainerId(Highcharts chart, string containerId)
        {
            if (string.IsNullOrWhiteSpace(containerId))
                return;

            chart.ID = containerId;
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
