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
	public partial class PlotOptionsBbParams  : BaseObject
	{
		public PlotOptionsBbParams()
		{
			Period = Period_DefaultValue = 20;
			StandardDeviation = StandardDeviation_DefaultValue = 2;
			Index = Index_DefaultValue = 3;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// Standard deviation for top and bottom bands.
		/// </summary>
		public double? StandardDeviation { get; set; }
		private double? StandardDeviation_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (StandardDeviation != StandardDeviation_DefaultValue) h.Add("standardDeviation",StandardDeviation);
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