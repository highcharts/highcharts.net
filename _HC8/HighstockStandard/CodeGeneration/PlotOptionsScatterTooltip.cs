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
	public partial class PlotOptionsScatterTooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsScatterTooltip()
		{
			HeaderFormat = HeaderFormat_DefaultValue = "<span style='color:{point.color}'>●</span> <span style='font-size: 10px'> {series.name}</span><br/>";
			PointFormat = PointFormat_DefaultValue = "x: <b>{point.x}</b><br/>y: <b>{point.y}</b><br/>";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string HeaderFormat { get; set; }
		private string HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
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