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
		}	
		

		/// <summary>
		/// The threshold for the value change.For example deviation=1 means the indicator will ignore all pricemovements less than 1%.
		/// </summary>
		public double? Deviation { get; set; }
		 

		/// <summary>
		/// The point index which indicator calculations will base - highvalue.For example using OHLC data, index=1 means the indicator will becalculated using High values.
		/// </summary>
		public double? HighIndex { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Index { get; set; }
		 

		/// <summary>
		/// The point index which indicator calculations will base - lowvalue.For example using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public double? LowIndex { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Period { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Deviation != null) h.Add("deviation",Deviation);
			if (HighIndex != null) h.Add("highIndex",HighIndex);
			if (Index != null) h.Add("index",Index);
			if (LowIndex != null) h.Add("lowIndex",LowIndex);
			if (Period != null) h.Add("period",Period);
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