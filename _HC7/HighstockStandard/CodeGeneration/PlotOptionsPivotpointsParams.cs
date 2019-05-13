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
	public partial class PlotOptionsPivotpointsParams  : BaseObject
	{
		public PlotOptionsPivotpointsParams()
		{
			Algorithm = Algorithm_DefaultValue = "standard";
			Index = Index_DefaultValue = 0;
			Period = Period_DefaultValue = 28;
			
		}	
		

		/// <summary>
		/// Algorithm used to calculate ressistance and support lines basedon pivot points. Implemented algorithms: `'standard'`,`'fibonacci'` and `'camarilla'`
		/// </summary>
		public string Algorithm { get; set; }
		private string Algorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// The point index which indicator calculations will base. Forexample using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Algorithm != Algorithm_DefaultValue) h.Add("algorithm",Algorithm);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			

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