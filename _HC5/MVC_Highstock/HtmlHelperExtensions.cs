using System;
using System.Web;
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
        public MvcHtmlString Highstock(Highstock chart, string containerId)
        {            
            var renderer = new HighstockRenderer(chart);
            AssignContainerId(chart, containerId);

            return MvcHtmlString.Create(renderer.RenderHtml());
        }

        public HtmlString GetHighstock(Highstock chart, string containerId, bool addContainer = true, string functionName = null)
        {
            if (functionName != null)
                return GetHighstockFunction(chart, containerId, functionName);

            var renderer = new HighstockRenderer(chart);
            AssignContainerId(chart, containerId);

            if (addContainer)
                return new HtmlString(renderer.RenderHtml());

            return new HtmlString(renderer.RenderHtml(addContainer));
        }

        public HtmlString GetHigstockJS(Highstock chart, string containerId)
        {
            var renderer = new HighstockRenderer(chart);
            AssignContainerId(chart, containerId);

            return new HtmlString(renderer.GetJavascript());
        }

        private HtmlString GetHighstockFunction(Highstock chart, string containerId, string functionName)
        {
            var renderer = new HighstockRenderer(chart);
            AssignContainerId(chart, containerId);

            return new HtmlString(renderer.GetJavascriptFunction(functionName));
        }
        
        private void AssignContainerId(Highstock chart, string containerId)
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
