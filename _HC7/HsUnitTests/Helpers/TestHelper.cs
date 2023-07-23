using Highsoft.Web.Mvc.Charts;
using HStock = Highsoft.Web.Mvc.Stocks;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Tests.Helpers
{
    public static class TestHelper
    {
		public static Series GetHcSeries(ChartType chartType)
		{ 
			switch (chartType)
			{

				case ChartType.Arcdiagram:
					return new ArcdiagramSeries();
				case ChartType.Area:
					return new AreaSeries();

				case ChartType.Line:
					return new LineSeries();

				default:
					return new Series();
			}
		}

		//public static HS.Series GetHsSeries(HS.ChartType chartType)
		//{

		//}

		public static string GetJsonLeadingPath(IEnumerable<string> properties)
        {
			StringBuilder sb = new StringBuilder();
			sb.Append($"\"");
			sb.Append(properties.Aggregate((p, q) => p = $"{p}\":{{\"{q}"));
			sb.Append($"\":{{");

			return sb.ToString();
        }

        public static string GetJsonLeadingPathForList(IEnumerable<string> properties)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\"");
            sb.Append(properties.Aggregate((p, q) => p = $"{p}\":{{\"{q}"));
            sb.Append($"\":[{{");

            return sb.ToString();
        }

        public static string GetJsonTrailingString(IEnumerable<string> properties)
        {
			return new string('}', properties.Count());
        }

        public static string GetJsonTrailingStringForList(IEnumerable<string> properties)
        {
			var trailingString = new StringBuilder();
			trailingString.Append("}]");
			//trailingString.Append(new string('}', properties.Count()));

            return trailingString.ToString();
        }

        public static string GetPropertyString(string name, double value)
        {
			return string.Format(CultureInfo.InvariantCulture, "\"{0}\":{1:N1}", name, value).Replace(",", "");
		}

        public static string GetPropertyString(string name, int value)
        {
            return $"\"{name}\":{value}";
        }

        public static string GetPropertyString(string name, string value)
        {
			return $"\"{name}\":\"{value}\"";
		}

		public static string GetPropertyString(string name, bool value)
        {
			return $"\"{name}\":{value.ToString().ToLower()}";
        }

		public static string GetEnumPropertyString(Highcharts chart, string name, string value)
		{
			return $"\"{name}\":\"{chart.FirstCharacterToLower(value.ToString())}\"";
        }

        public static string GetEnumPropertyString(HStock.Highstock chart, string name, string value)
        {
            return $"\"{name}\":\"{chart.FirstCharacterToLower(value.ToString())}\"";
        }

        public static string GetFunctionPropertyString(string name, string value)
		{
			return $"\"{name}\":{value}";
		}

		public static string GetHashtablePropertyString(string propertyName, string paramName, string paramValue)
		{
			return $"\"{propertyName}\":{{{GetPropertyString(paramName, paramValue)}}}";
        }

        public static string GetHashtablePropertyString(string propertyName, string paramName, double paramValue)
		{
			return $"\"{propertyName}\":{{{GetPropertyString(paramName, paramValue)}}}";
		}
    }
}
