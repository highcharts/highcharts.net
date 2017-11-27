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
	public partial class PlotOptionsGaugeDataLabels  : BaseObject
	{
		public PlotOptionsGaugeDataLabels()
		{
			Enabled = Enabled_DefaultValue = True;
			Defer = Defer_DefaultValue = False;
			Y = Y_DefaultValue = 15;
			BorderRadius = BorderRadius_DefaultValue = 3;
			Crop = Crop_DefaultValue = False;
			VerticalAlign = VerticalAlign_DefaultValue = "top";
			ZIndex = ZIndex_DefaultValue = 2;
			BorderWidth = BorderWidth_DefaultValue = 1;
			BorderColor = BorderColor_DefaultValue = "#cccccc";
			Enabled = Enabled_DefaultValue = True;
			Defer = Defer_DefaultValue = False;
			Y = Y_DefaultValue = 15;
			BorderRadius = BorderRadius_DefaultValue = 3;
			Crop = Crop_DefaultValue = False;
			VerticalAlign = VerticalAlign_DefaultValue = "top";
			ZIndex = ZIndex_DefaultValue = 2;
			BorderWidth = BorderWidth_DefaultValue = 1;
			BorderColor = BorderColor_DefaultValue = "#cccccc";
			Enabled = Enabled_DefaultValue = True;
			Defer = Defer_DefaultValue = False;
			Y = Y_DefaultValue = 15;
			BorderRadius = BorderRadius_DefaultValue = 3;
			Crop = Crop_DefaultValue = False;
			VerticalAlign = VerticalAlign_DefaultValue = "top";
			ZIndex = ZIndex_DefaultValue = 2;
			BorderWidth = BorderWidth_DefaultValue = 1;
			BorderColor = BorderColor_DefaultValue = "#cccccc";
			Enabled = Enabled_DefaultValue = True;
			Defer = Defer_DefaultValue = False;
			Y = Y_DefaultValue = 15;
			BorderRadius = BorderRadius_DefaultValue = 3;
			Crop = Crop_DefaultValue = False;
			VerticalAlign = VerticalAlign_DefaultValue = "top";
			ZIndex = ZIndex_DefaultValue = 2;
			BorderWidth = BorderWidth_DefaultValue = 1;
			BorderColor = BorderColor_DefaultValue = "#cccccc";
			
		}	
		

		/// <summary>
		/// Enable or disable the data labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeDataLabelsDefer Defer { get; set; }
		private PlotOptionsGaugeDataLabelsDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the center of thegauge.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border radius in pixels for the gauge's data label.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeDataLabelsCrop Crop { get; set; }
		private PlotOptionsGaugeDataLabelsCrop Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the data label.
		/// </summary>
		public string VerticalAlign { get; set; }
		private string VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the data labels. A value of 2 display them behindthe dial.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width in pixels for the gauge data label.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the data label.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the data labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeDataLabelsDefer Defer { get; set; }
		private PlotOptionsGaugeDataLabelsDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the center of thegauge.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border radius in pixels for the gauge's data label.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeDataLabelsCrop Crop { get; set; }
		private PlotOptionsGaugeDataLabelsCrop Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the data label.
		/// </summary>
		public string VerticalAlign { get; set; }
		private string VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the data labels. A value of 2 display them behindthe dial.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width in pixels for the gauge data label.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the data label.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the data labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeDataLabelsDefer Defer { get; set; }
		private PlotOptionsGaugeDataLabelsDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the center of thegauge.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border radius in pixels for the gauge's data label.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeDataLabelsCrop Crop { get; set; }
		private PlotOptionsGaugeDataLabelsCrop Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the data label.
		/// </summary>
		public string VerticalAlign { get; set; }
		private string VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the data labels. A value of 2 display them behindthe dial.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width in pixels for the gauge data label.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the data label.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the data labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeDataLabelsDefer Defer { get; set; }
		private PlotOptionsGaugeDataLabelsDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the center of thegauge.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border radius in pixels for the gauge's data label.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsGaugeDataLabelsCrop Crop { get; set; }
		private PlotOptionsGaugeDataLabelsCrop Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the data label.
		/// </summary>
		public string VerticalAlign { get; set; }
		private string VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the data labels. A value of 2 display them behindthe dial.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width in pixels for the gauge data label.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the data label.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			

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