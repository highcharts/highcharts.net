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
	public partial class PlotOptionsTrendlineParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTrendlineParams()
		{
			Index = Index_DefaultValue = "3";
			IndexNumber = IndexNumber_DefaultValue = null;
			Period = Period_DefaultValue = "undefined";
			
		}	
		

		/// <summary>
		/// The point index which indicator calculations will base. Forexample using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public string Index { get; set; }
		private string Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// The point index which indicator calculations will base. Forexample using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public double? IndexNumber { get; set; }
		private double? IndexNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Period { get; set; }
		private string Period_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (IndexNumber != IndexNumber_DefaultValue) h.Add("index",IndexNumber);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}