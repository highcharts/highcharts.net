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
		public PlotOptionsLinearregressionParams()
		{
			Index = Index_DefaultValue = 0;
			Period = Period_DefaultValue = 14;
			XAxisUnit = XAxisUnit_DefaultValue = null;
			
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
		/// Unit (in milliseconds) for the x axis distances used to computethe regression line paramters (slope & intercept) for everyrange. In Highstock the x axis values are always represented inmilliseconds which may cause that distances between points are"big" integer numbers.Highstock's linear regression algorithm (least squares method)will utilize these "big" integers for finding the slope and theintercept of the regression line for each period. In consequence,this value may be a very "small" decimal number that's hard tointerpret by a human.For instance: `xAxisUnit` equealed to `86400000` ms (1 day)forces the algorithm to treat `86400000` as `1` while computingthe slope and the intercept. This may enchance the legiblitity ofthe indicator's values.Default value is the closest distance between two data points.
		/// </summary>
		public double? XAxisUnit { get; set; }
		private double? XAxisUnit_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (XAxisUnit != XAxisUnit_DefaultValue) h.Add("xAxisUnit",XAxisUnit);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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