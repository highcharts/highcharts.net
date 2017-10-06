using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsMacdParams  : BaseObject
	{
		public PlotOptionsMacdParams()
		{
			ShortPeriod = ShortPeriod_DefaultValue = null;
			LongPeriod = LongPeriod_DefaultValue = null;
			SignalPeriod = SignalPeriod_DefaultValue = null;
			Period = Period_DefaultValue = null;
			Index = Index_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The short period for indicator calculations.</p>
		/// </summary>
		public double? ShortPeriod { get; set; }
		private double? ShortPeriod_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The long period for indicator calculations.</p>
		/// </summary>
		public double? LongPeriod { get; set; }
		private double? LongPeriod_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The base period for signal calculations.</p>
		/// </summary>
		public double? SignalPeriod { get; set; }
		private double? SignalPeriod_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The base period for indicator calculations.</p>
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The point index which indicator calculations will base.For example using OHLC data, index=2 means the indicator will be calculated using Low values.</p>
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ShortPeriod != ShortPeriod_DefaultValue) h.Add("shortPeriod",ShortPeriod);
			if (LongPeriod != LongPeriod_DefaultValue) h.Add("longPeriod",LongPeriod);
			if (SignalPeriod != SignalPeriod_DefaultValue) h.Add("signalPeriod",SignalPeriod);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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