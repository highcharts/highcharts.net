using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class LegendBubbleLegendRanges  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LegendBubbleLegendRanges()
		{
		}	
		

		/// <summary>
		/// The color of the border for individual range.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The color of the bubble for individual range.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// The color of the connector for individual range.
		/// </summary>
		public string ConnectorColor { get; set; }
		 

		/// <summary>
		/// Range size value, similar to bubble Z data.
		/// </summary>
		public double? Value { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (Color != null) h.Add("color",Color);
			if (ConnectorColor != null) h.Add("connectorColor",ConnectorColor);
			if (Value != null) h.Add("value",Value);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}