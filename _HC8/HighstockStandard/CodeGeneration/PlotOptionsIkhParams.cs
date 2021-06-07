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
	public partial class PlotOptionsIkhParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsIkhParams()
		{
			Index = Index_DefaultValue = "undefined";
			Period = Period_DefaultValue = 26;
			PeriodSenkouSpanB = PeriodSenkouSpanB_DefaultValue = 52;
			PeriodTenkan = PeriodTenkan_DefaultValue = 9;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Index { get; set; }
		private string Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// The base period for Senkou Span B calculations
		/// </summary>
		public double? PeriodSenkouSpanB { get; set; }
		private double? PeriodSenkouSpanB_DefaultValue { get; set; }
		 

		/// <summary>
		/// The base period for Tenkan calculations.
		/// </summary>
		public double? PeriodTenkan { get; set; }
		private double? PeriodTenkan_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (PeriodSenkouSpanB != PeriodSenkouSpanB_DefaultValue) h.Add("periodSenkouSpanB",PeriodSenkouSpanB);
			if (PeriodTenkan != PeriodTenkan_DefaultValue) h.Add("periodTenkan",PeriodTenkan);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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