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
	public partial class PlotOptionsLinearregressionParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsLinearregressionParams()
		{
			Index = Index_DefaultValue = 3;
			Period = Period_DefaultValue = 14;
			XAxisUnit = XAxisUnit_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The point index which indicator calculations will base. Forexample using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// The base period for indicator calculations. This is the number ofdata points which are taken into account for the indicatorcalculations.
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// Unit (in milliseconds) for the x axis distances used tocompute the regression line parameters (slope & intercept)for every range. In Highcharts Stock the x axis values arealways represented in milliseconds which may cause thatdistances between points are "big" integer numbers.Highcharts Stock's linear regression algorithm (least squaresmethod) will utilize these "big" integers for finding theslope and the intercept of the regression line for eachperiod. In consequence, this value may be a very "small"decimal number that's hard to interpret by a human.For instance: `xAxisUnit` equaled to `86400000` ms (1 day)forces the algorithm to treat `86400000` as `1` whilecomputing the slope and the intercept. This may enhance thelegibility of the indicator's values.Default value is the closest distance between two datapoints.In `v9.0.2`, the default value has been changedfrom `undefined` to `null`.
		/// </summary>
		public double? XAxisUnit { get; set; }
		private double? XAxisUnit_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (XAxisUnit != XAxisUnit_DefaultValue) h.Add("xAxisUnit",XAxisUnit);
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