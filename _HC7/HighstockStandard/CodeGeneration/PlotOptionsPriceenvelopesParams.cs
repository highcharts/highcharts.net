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
	public partial class PlotOptionsPriceenvelopesParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPriceenvelopesParams()
		{
		}	
		

		/// <summary>
		/// Percentage below the moving average that should be displayed.0.1 means 90%. Relative to the calculated value.
		/// </summary>
		public double? BottomBand { get; set; }
		 

		/// <summary>
		/// The point index which indicator calculations will base. Forexample using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public double? Index { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Period { get; set; }
		 

		/// <summary>
		/// Percentage above the moving average that should be displayed.0.1 means 110%. Relative to the calculated value.
		/// </summary>
		public double? TopBand { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (BottomBand != null) h.Add("bottomBand",BottomBand);
			if (Index != null) h.Add("index",Index);
			if (Period != null) h.Add("period",Period);
			if (TopBand != null) h.Add("topBand",TopBand);
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