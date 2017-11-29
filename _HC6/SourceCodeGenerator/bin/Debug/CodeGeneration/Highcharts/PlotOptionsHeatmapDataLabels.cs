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
	public partial class PlotOptionsHeatmapDataLabels  : BaseObject
	{
		public PlotOptionsHeatmapDataLabels()
		{
			Formatter = Formatter_DefaultValue = null;
			Inside = Inside_DefaultValue = True;
			VerticalAlign = VerticalAlign_DefaultValue = middle;
			Crop = Crop_DefaultValue = False;
			Overflow = Overflow_DefaultValue = False;
			Padding = Padding_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapDataLabelsFormatter Formatter { get; set; }
		private PlotOptionsHeatmapDataLabelsFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapDataLabelsInside Inside { get; set; }
		private PlotOptionsHeatmapDataLabelsInside Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapDataLabelsVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsHeatmapDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapDataLabelsCrop Crop { get; set; }
		private PlotOptionsHeatmapDataLabelsCrop Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapDataLabelsOverflow Overflow { get; set; }
		private PlotOptionsHeatmapDataLabelsOverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapDataLabelsPadding Padding { get; set; }
		private PlotOptionsHeatmapDataLabelsPadding Padding_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

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