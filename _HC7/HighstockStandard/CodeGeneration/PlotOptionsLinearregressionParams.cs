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
		}	
		

		/// <summary>
		/// The point index which indicator calculations will base. Forexample using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public double? Index { get; set; }
		 

		/// <summary>
		/// The base period for indicator calculations. This is the number ofdata points which are taken into account for the indicatorcalculations.
		/// </summary>
		public double? Period { get; set; }
		 

		/// <summary>
		/// Unit (in milliseconds) for the x axis distances used tocompute the regression line parameters (slope & intercept)for every range. In Highcharts Stock the x axis values arealways represented in milliseconds which may cause thatdistances between points are "big" integer numbers.Highcharts Stock's linear regression algorithm (least squaresmethod) will utilize these "big" integers for finding theslope and the intercept of the regression line for eachperiod. In consequence, this value may be a very "small"decimal number that's hard to interpret by a human.For instance: `xAxisUnit` equaled to `86400000` ms (1 day)forces the algorithm to treat `86400000` as `1` whilecomputing the slope and the intercept. This may enhance thelegibility of the indicator's values.Default value is the closest distance between two datapoints.In `v9.0.2`, the default value has been changedfrom `undefined` to `null`.
		/// </summary>
		public double? XAxisUnit { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Index != null) h.Add("index",Index);
			if (Period != null) h.Add("period",Period);
			if (XAxisUnit != null) h.Add("xAxisUnit",XAxisUnit);
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