using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsDmiTooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsDmiTooltip()
		{
			PointFormat = PointFormat_DefaultValue = "<span style='color: {point.color}'>●</span><b> {series.name}</b><br/><span style='color: {point.color}'>DX</span>: {point.y}<br/><span style='color: {point.series.options.plusDILine.styles.lineColor}'>+DI</span>: {point.plusDI}<br/><span style='color: {point.series.options.minusDILine.styles.lineColor}'>-DI</span>: {point.minusDI}<br/>";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}