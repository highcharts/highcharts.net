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
	public partial class PlotOptionsMacdTooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsMacdTooltip()
		{
			PointFormat = PointFormat_DefaultValue = "<span style='color:{point.color}'>●</span> <b> {series.name}</b><br/>Value: {point.MACD}<br/>Signal: {point.signal}<br/>Histogram: {point.y}<br/>";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}