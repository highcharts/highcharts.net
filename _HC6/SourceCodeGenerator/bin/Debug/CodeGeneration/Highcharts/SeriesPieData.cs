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
	public partial class SeriesPieData  : BaseObject
	{
		public SeriesPieData()
		{
			LegendIndex = LegendIndex_DefaultValue = null;
			Sliced = Sliced_DefaultValue = null;
			LegendIndex = LegendIndex_DefaultValue = null;
			Sliced = Sliced_DefaultValue = "";
			LegendIndex = LegendIndex_DefaultValue = null;
			Sliced = Sliced_DefaultValue = "";
			LegendIndex = LegendIndex_DefaultValue = null;
			Sliced = Sliced_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// The sequential index of the data point in the legend.
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display a slice offset from the center.
		/// </summary>
		public bool? Sliced { get; set; }
		private bool? Sliced_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sequential index of the data point in the legend.
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display a slice offset from the center.
		/// </summary>
		public bool? Sliced { get; set; }
		private bool? Sliced_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sequential index of the data point in the legend.
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display a slice offset from the center.
		/// </summary>
		public bool? Sliced { get; set; }
		private bool? Sliced_DefaultValue { get; set; }
		 

		/// <summary>
		/// The sequential index of the data point in the legend.
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display a slice offset from the center.
		/// </summary>
		public bool? Sliced { get; set; }
		private bool? Sliced_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (Sliced != Sliced_DefaultValue) h.Add("sliced",Sliced);
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (Sliced != Sliced_DefaultValue) h.Add("sliced",Sliced);
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (Sliced != Sliced_DefaultValue) h.Add("sliced",Sliced);
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (Sliced != Sliced_DefaultValue) h.Add("sliced",Sliced);
			

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