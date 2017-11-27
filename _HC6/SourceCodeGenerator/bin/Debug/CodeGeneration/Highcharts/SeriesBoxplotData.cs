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
	public partial class SeriesBoxplotData  : BaseObject
	{
		public SeriesBoxplotData()
		{
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			Median = Median_DefaultValue = null;
			Q1 = Q1_DefaultValue = null;
			Q3 = Q3_DefaultValue = null;
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			Median = Median_DefaultValue = null;
			Q1 = Q1_DefaultValue = null;
			Q3 = Q3_DefaultValue = null;
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			Median = Median_DefaultValue = null;
			Q1 = Q1_DefaultValue = null;
			Q3 = Q3_DefaultValue = null;
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			Median = Median_DefaultValue = null;
			Q1 = Q1_DefaultValue = null;
			Q3 = Q3_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The `high` value for each data point, signifying the highest valuein the sample set. The top whisker is drawn here.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `low` value for each data point, signifying the lowest valuein the sample set. The bottom whisker is drawn here.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The median for each data point. This is drawn as a line through themiddle area of the box.
		/// </summary>
		public double? Median { get; set; }
		private double? Median_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lower quartile for each data point. This is the bottom of thebox.
		/// </summary>
		public double? Q1 { get; set; }
		private double? Q1_DefaultValue { get; set; }
		 

		/// <summary>
		/// The higher quartile for each data point. This is the top of the box.
		/// </summary>
		public double? Q3 { get; set; }
		private double? Q3_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `high` value for each data point, signifying the highest valuein the sample set. The top whisker is drawn here.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `low` value for each data point, signifying the lowest valuein the sample set. The bottom whisker is drawn here.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The median for each data point. This is drawn as a line through themiddle area of the box.
		/// </summary>
		public double? Median { get; set; }
		private double? Median_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lower quartile for each data point. This is the bottom of thebox.
		/// </summary>
		public double? Q1 { get; set; }
		private double? Q1_DefaultValue { get; set; }
		 

		/// <summary>
		/// The higher quartile for each data point. This is the top of the box.
		/// </summary>
		public double? Q3 { get; set; }
		private double? Q3_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `high` value for each data point, signifying the highest valuein the sample set. The top whisker is drawn here.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `low` value for each data point, signifying the lowest valuein the sample set. The bottom whisker is drawn here.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The median for each data point. This is drawn as a line through themiddle area of the box.
		/// </summary>
		public double? Median { get; set; }
		private double? Median_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lower quartile for each data point. This is the bottom of thebox.
		/// </summary>
		public double? Q1 { get; set; }
		private double? Q1_DefaultValue { get; set; }
		 

		/// <summary>
		/// The higher quartile for each data point. This is the top of the box.
		/// </summary>
		public double? Q3 { get; set; }
		private double? Q3_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `high` value for each data point, signifying the highest valuein the sample set. The top whisker is drawn here.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `low` value for each data point, signifying the lowest valuein the sample set. The bottom whisker is drawn here.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The median for each data point. This is drawn as a line through themiddle area of the box.
		/// </summary>
		public double? Median { get; set; }
		private double? Median_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lower quartile for each data point. This is the bottom of thebox.
		/// </summary>
		public double? Q1 { get; set; }
		private double? Q1_DefaultValue { get; set; }
		 

		/// <summary>
		/// The higher quartile for each data point. This is the top of the box.
		/// </summary>
		public double? Q3 { get; set; }
		private double? Q3_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (Median != Median_DefaultValue) h.Add("median",Median);
			if (Q1 != Q1_DefaultValue) h.Add("q1",Q1);
			if (Q3 != Q3_DefaultValue) h.Add("q3",Q3);
			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (Median != Median_DefaultValue) h.Add("median",Median);
			if (Q1 != Q1_DefaultValue) h.Add("q1",Q1);
			if (Q3 != Q3_DefaultValue) h.Add("q3",Q3);
			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (Median != Median_DefaultValue) h.Add("median",Median);
			if (Q1 != Q1_DefaultValue) h.Add("q1",Q1);
			if (Q3 != Q3_DefaultValue) h.Add("q3",Q3);
			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (Median != Median_DefaultValue) h.Add("median",Median);
			if (Q1 != Q1_DefaultValue) h.Add("q1",Q1);
			if (Q3 != Q3_DefaultValue) h.Add("q3",Q3);
			

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