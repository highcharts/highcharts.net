using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class SeriesArearangeData  : BaseObject
	{
		public SeriesArearangeData()
		{
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The high or maximum value for each data point.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The low or minimum value for each data point.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The high or maximum value for each data point.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The low or minimum value for each data point.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The high or maximum value for each data point.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The low or minimum value for each data point.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The high or maximum value for each data point.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The low or minimum value for each data point.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			

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