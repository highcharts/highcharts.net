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
	public partial class TreemapSeriesDataLabels  : BaseObject
	{
		public TreemapSeriesDataLabels()
		{
			Enabled = Enabled_DefaultValue = true;
			Defer = Defer_DefaultValue = false;
			Formatter = Formatter_DefaultValue = "";
			Inside = Inside_DefaultValue = true;
			VerticalAlign = VerticalAlign_DefaultValue = middle;
			Crop = Crop_DefaultValue = false;
			Overflow = Overflow_DefaultValue = false;
			Padding = Padding_DefaultValue = "0";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public TreemapSeriesDataLabelsEnabled Enabled { get; set; }
		private TreemapSeriesDataLabelsEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TreemapSeriesDataLabelsDefer Defer { get; set; }
		private TreemapSeriesDataLabelsDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TreemapSeriesDataLabelsFormatter Formatter { get; set; }
		private TreemapSeriesDataLabelsFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TreemapSeriesDataLabelsInside Inside { get; set; }
		private TreemapSeriesDataLabelsInside Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TreemapSeriesDataLabelsVerticalAlign VerticalAlign { get; set; }
		private TreemapSeriesDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TreemapSeriesDataLabelsCrop Crop { get; set; }
		private TreemapSeriesDataLabelsCrop Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TreemapSeriesDataLabelsOverflow Overflow { get; set; }
		private TreemapSeriesDataLabelsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			

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