using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class LegendBubbleLegend  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LegendBubbleLegend()
		{
			BorderColor = BorderColor_DefaultValue = "undefined";
			BorderWidth = BorderWidth_DefaultValue = 2;
			ClassName = ClassName_DefaultValue = "undefined";
			Color = Color_DefaultValue = "undefined";
			ConnectorClassName = ConnectorClassName_DefaultValue = "undefined";
			ConnectorColor = ConnectorColor_DefaultValue = "undefined";
			ConnectorDistance = ConnectorDistance_DefaultValue = 60;
			ConnectorWidth = ConnectorWidth_DefaultValue = 1;
			Enabled = Enabled_DefaultValue = false;
			Labels = Labels_DefaultValue = new LegendBubbleLegendLabels();
			LegendIndex = LegendIndex_DefaultValue = 0;
			MaxSize = MaxSize_DefaultValue = 60;
			MinSize = MinSize_DefaultValue = 10;
			Ranges = Ranges_DefaultValue = new LegendBubbleLegendRanges();
			SizeBy = SizeBy_DefaultValue = "area";
			SizeByAbsoluteValue = SizeByAbsoluteValue_DefaultValue = false;
			ZIndex = ZIndex_DefaultValue = 1;
			ZThreshold = ZThreshold_DefaultValue = 0;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The color of the ranges borders, can be also defined for anindividual range.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the ranges borders in pixels, can be alsodefined for an individual range.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional class name to apply to the bubble legend'circle graphical elements. This option does not replacedefault class names of the graphical element.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the bubble legend. Applies to ranges, ifindividual color is not defined.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional class name to apply to the bubble legend'sconnector graphical elements. This option does not replacedefault class names of the graphical element.
		/// </summary>
		public string ConnectorClassName { get; set; }
		private string ConnectorClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the connector, can be also definedfor an individual range.
		/// </summary>
		public string ConnectorColor { get; set; }
		private string ConnectorColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the connectors in pixels. If labels arecentered, the distance is reduced to 0.
		/// </summary>
		public double? ConnectorDistance { get; set; }
		private double? ConnectorDistance_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the connectors in pixels.
		/// </summary>
		public double? ConnectorWidth { get; set; }
		private double? ConnectorWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the bubble legend.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the bubble legend labels.
		/// </summary>
		public LegendBubbleLegendLabels Labels { get; set; }
		private LegendBubbleLegendLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the bubble legend in the legend.
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Miximum bubble legend range size. If values for ranges arenot specified, the `minSize` and the `maxSize` are calculatedfrom bubble series.
		/// </summary>
		public double? MaxSize { get; set; }
		private double? MaxSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Minimum bubble legend range size. If values for ranges arenot specified, the `minSize` and the `maxSize` are calculatedfrom bubble series.
		/// </summary>
		public double? MinSize { get; set; }
		private double? MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for specific range. One range consists of bubble,label and connector.
		/// </summary>
		public LegendBubbleLegendRanges Ranges { get; set; }
		private LegendBubbleLegendRanges Ranges_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the bubble legend range value should be representedby the area or the width of the bubble. The default, area,corresponds best to the human perception of the size of eachbubble.
		/// </summary>
		public string SizeBy { get; set; }
		private string SizeBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this is true, the absolute value of z determines thesize of the bubble. This means that with the defaultzThreshold of 0, a bubble of value -1 will have the same sizeas a bubble of value 1, while a bubble of value 0 will have asmaller size according to minSize.
		/// </summary>
		public bool? SizeByAbsoluteValue { get; set; }
		private bool? SizeByAbsoluteValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// Define the visual z index of the bubble legend.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Ranges with with lower value than zThreshold, are skipped.
		/// </summary>
		public double? ZThreshold { get; set; }
		private double? ZThreshold_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ConnectorClassName != ConnectorClassName_DefaultValue) h.Add("connectorClassName",ConnectorClassName);
			if (ConnectorColor != ConnectorColor_DefaultValue) h.Add("connectorColor",ConnectorColor);
			if (ConnectorDistance != ConnectorDistance_DefaultValue) h.Add("connectorDistance",ConnectorDistance);
			if (ConnectorWidth != ConnectorWidth_DefaultValue) h.Add("connectorWidth",ConnectorWidth);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (MaxSize != MaxSize_DefaultValue) h.Add("maxSize",MaxSize);
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (Ranges.IsDirty()) h.Add("ranges",Ranges.ToHashtable());
			if (SizeBy != SizeBy_DefaultValue) h.Add("sizeBy",SizeBy);
			if (SizeByAbsoluteValue != SizeByAbsoluteValue_DefaultValue) h.Add("sizeByAbsoluteValue",SizeByAbsoluteValue);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (ZThreshold != ZThreshold_DefaultValue) h.Add("zThreshold",ZThreshold);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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