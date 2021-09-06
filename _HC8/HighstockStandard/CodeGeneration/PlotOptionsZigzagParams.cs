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
	public partial class PlotOptionsZigzagParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsZigzagParams()
		{
			Deviation = Deviation_DefaultValue = 1;
			HighIndex = HighIndex_DefaultValue = 1;
			Index = Index_DefaultValue = "undefined";
			LowIndex = LowIndex_DefaultValue = 2;
			Period = Period_DefaultValue = "undefined";
			
		}	
		

		/// <summary>
		/// The threshold for the value change.For example deviation=1 means the indicator will ignore all pricemovements less than 1%.
		/// </summary>
		public double? Deviation { get; set; }
		private double? Deviation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The point index which indicator calculations will base - highvalue.For example using OHLC data, index=1 means the indicator will becalculated using High values.
		/// </summary>
		public double? HighIndex { get; set; }
		private double? HighIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Index { get; set; }
		private string Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// The point index which indicator calculations will base - lowvalue.For example using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public double? LowIndex { get; set; }
		private double? LowIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Period { get; set; }
		private string Period_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Deviation != Deviation_DefaultValue) h.Add("deviation",Deviation);
			if (HighIndex != HighIndex_DefaultValue) h.Add("highIndex",HighIndex);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (LowIndex != LowIndex_DefaultValue) h.Add("lowIndex",LowIndex);
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