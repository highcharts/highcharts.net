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
	public partial class PlotOptionsWindbarbTooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsWindbarbTooltip()
		{
			PointFormat = PointFormat_DefaultValue = "<span style='color:{point.color}'>●</span> {series.name}: <b>{point.value}</b> ({point.beaufort})<br/>";
			
		}	
		

		/// <summary>
		/// The default point format for the wind barb tooltip. Note the`point.beaufort` property that refers to the Beaufort wind scale.The names can be internationalized by modifying`Highcharts.seriesTypes.windbarb.prototype.beaufortNames`.
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			

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