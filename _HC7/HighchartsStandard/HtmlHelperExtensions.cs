using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Highsoft.Web.Mvc.Charts.Rendering;
using Highsoft.Web.Mvc.Charts;

namespace Highsoft.Web.Mvc.Charts
{
    public class HighsoftNamespace
    {
        public string GetHighcharts(Highcharts chart, string containerId, bool addContainer = true, string functionName = null)
        {
            if (functionName != null)
                return GetHighchartsFunction(chart, containerId, functionName);

            var renderer = new HighchartsRenderer(chart);
            AssignContainerId(chart, containerId);

            if(addContainer)
                return renderer.RenderHtml();

            return renderer.RenderHtml(addContainer);
        }

        public string GetHighchartsJS(Highcharts chart, string containerId)
        {
            var renderer = new HighchartsRenderer(chart);
            AssignContainerId(chart, containerId);

            return renderer.GetJavascript();
        }

        public string GetJsonOptions(Highcharts chart)
        {
            var renderer = new HighchartsRenderer(chart);
            return renderer.GetJsonOptions();
        }

        public string SetOptions(Global global = null, Lang lang = null)
        {
            var renderer = new HighchartsRenderer();
            return renderer.SetOptions(global, lang);
        }

        private string GetHighchartsFunction(Highcharts chart, string containerId, string functionName)
        {
            var renderer = new HighchartsRenderer(chart);
            AssignContainerId(chart, containerId);

            return renderer.GetJavascriptFunction(functionName);
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
