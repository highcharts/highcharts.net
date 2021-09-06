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
	public partial class PlotOptionsAbandsParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsAbandsParams()
		{
			Factor = Factor_DefaultValue = null;
			Index = Index_DefaultValue = 3;
			Period = Period_DefaultValue = 20;
			
		}	
		

		/// <summary>
		/// The algorithms factor value used to calculate bands.
		/// </summary>
		public double? Factor { get; set; }
		private double? Factor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Factor != Factor_DefaultValue) h.Add("factor",Factor);
			if (Index != Index_DefaultValue) h.Add("index",Index);
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