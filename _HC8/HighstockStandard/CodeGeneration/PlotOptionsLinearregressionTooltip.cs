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
	public partial class PlotOptionsLinearregressionTooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsLinearregressionTooltip()
		{
			ValueDecimals = ValueDecimals_DefaultValue = 4;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? ValueDecimals { get; set; }
		private double? ValueDecimals_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ValueDecimals != ValueDecimals_DefaultValue) h.Add("valueDecimals",ValueDecimals);
			

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