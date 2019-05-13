using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Highsoft.Web.Mvc.Stocks;
using Highsoft.Web.Mvc.Stocks.Rendering;

namespace Highsoft.Web.Mvc.Stocks
{
    public class HighsoftNamespace
    {

        private readonly string _SerialKey;
        public HighsoftNamespace(string key = null)
        {
            _SerialKey = key;
        }

        public string GetHighstock(Highstock chart, string containerId, bool addContainer = true, string functionName = null)
        {
            if (functionName != null)
                return GetHighstockFunction(chart, containerId, functionName);

            var renderer = new HighstockRenderer(chart);
            AssignContainerId(chart, containerId);

            if (addContainer)
                return renderer.RenderHtml();

            return renderer.RenderHtml(addContainer);
        }

        public string GetHigstockJS(Highstock chart, string containerId)
        {
            var renderer = new HighstockRenderer(chart, _SerialKey);
            AssignContainerId(chart, containerId);

            return renderer.GetJavascript();
        }

        public string GetJsonOptions(Highstock chart)
        {
            var renderer = new HighstockRenderer(chart, _SerialKey);
            return renderer.GetJsonOptions();
        }

        public string SetOptions(Global global = null, Lang lang = null)
        {
            var renderer = new HighstockRenderer();
            return renderer.SetOptions(global, lang);
        }

        private string GetHighstockFunction(Highstock chart, string containerId, string functionName)
        {
            var renderer = new HighstockRenderer(chart, _SerialKey);
            AssignContainerId(chart, containerId);

            return renderer.GetJavascriptFunction(functionName);
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
