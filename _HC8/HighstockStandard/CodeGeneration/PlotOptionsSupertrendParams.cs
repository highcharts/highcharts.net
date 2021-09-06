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
	public partial class PlotOptionsSupertrendParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSupertrendParams()
		{
			Index = Index_DefaultValue = "undefined";
			Multiplier = Multiplier_DefaultValue = 3;
			Period = Period_DefaultValue = 10;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Index { get; set; }
		private string Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// Multiplier for Supertrend Indicator.
		/// </summary>
		public double? Multiplier { get; set; }
		private double? Multiplier_DefaultValue { get; set; }
		 

		/// <summary>
		/// The base period for indicator Supertrend Indicator calculations.This is the number of data points which are taken into accountfor the indicator calculations.
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Multiplier != Multiplier_DefaultValue) h.Add("multiplier",Multiplier);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			

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