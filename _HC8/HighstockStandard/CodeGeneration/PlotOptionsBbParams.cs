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
	public partial class PlotOptionsBbParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsBbParams()
		{
			Index = Index_DefaultValue = 3;
			Period = Period_DefaultValue = 20;
			StandardDeviation = StandardDeviation_DefaultValue = 2;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// Standard deviation for top and bottom bands.
		/// </summary>
		public double? StandardDeviation { get; set; }
		private double? StandardDeviation_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (StandardDeviation != StandardDeviation_DefaultValue) h.Add("standardDeviation",StandardDeviation);
			

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