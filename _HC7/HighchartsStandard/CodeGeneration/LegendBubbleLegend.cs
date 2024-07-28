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
		}	
		

		/// <summary>
		/// The color of the ranges borders, can be also defined for anindividual range.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// The width of the ranges borders in pixels, can be alsodefined for an individual range.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// An additional class name to apply to the bubble legend'circle graphical elements. This option does not replacedefault class names of the graphical element.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// The main color of the bubble legend. Applies to ranges, ifindividual color is not defined.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// An additional class name to apply to the bubble legend'sconnector graphical elements. This option does not replacedefault class names of the graphical element.
		/// </summary>
		public string ConnectorClassName { get; set; }
		 

		/// <summary>
		/// The color of the connector, can be also definedfor an individual range.
		/// </summary>
		public string ConnectorColor { get; set; }
		 

		/// <summary>
		/// The length of the connectors in pixels. If labels arecentered, the distance is reduced to 0.
		/// </summary>
		public double? ConnectorDistance { get; set; }
		 

		/// <summary>
		/// The width of the connectors in pixels.
		/// </summary>
		public double? ConnectorWidth { get; set; }
		 

		/// <summary>
		/// Enable or disable the bubble legend.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Options for the bubble legend labels.
		/// </summary>
		public LegendBubbleLegendLabels Labels { get; set; }
		 

		/// <summary>
		/// The position of the bubble legend in the legend.
		/// </summary>
		public double? LegendIndex { get; set; }
		 

		/// <summary>
		/// Maximum bubble legend range size. If values for ranges arenot specified, the `minSize` and the `maxSize` are calculatedfrom bubble series.
		/// </summary>
		public double? MaxSize { get; set; }
		 

		/// <summary>
		/// Minimum bubble legend range size. If values for ranges arenot specified, the `minSize` and the `maxSize` are calculatedfrom bubble series.
		/// </summary>
		public double? MinSize { get; set; }
		 

		/// <summary>
		/// Options for specific range. One range consists of bubble,label and connector.
		/// </summary>
		public LegendBubbleLegendRanges Ranges { get; set; }
		 

		/// <summary>
		/// Whether the bubble legend range value should be representedby the area or the width of the bubble. The default, area,corresponds best to the human perception of the size of eachbubble.
		/// </summary>
		public string SizeBy { get; set; }
		 

		/// <summary>
		/// When this is true, the absolute value of z determines thesize of the bubble. This means that with the defaultzThreshold of 0, a bubble of value -1 will have the same sizeas a bubble of value 1, while a bubble of value 0 will have asmaller size according to minSize.
		/// </summary>
		public bool? SizeByAbsoluteValue { get; set; }
		 

		/// <summary>
		/// Define the visual z index of the bubble legend.
		/// </summary>
		public double? ZIndex { get; set; }
		 

		/// <summary>
		/// Ranges with lower value than zThreshold are skipped.
		/// </summary>
		public double? ZThreshold { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (ClassName != null) h.Add("className",ClassName);
			if (Color != null) h.Add("color",Color);
			if (ConnectorClassName != null) h.Add("connectorClassName",ConnectorClassName);
			if (ConnectorColor != null) h.Add("connectorColor",ConnectorColor);
			if (ConnectorDistance != null) h.Add("connectorDistance",ConnectorDistance);
			if (ConnectorWidth != null) h.Add("connectorWidth",ConnectorWidth);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Labels != null) h.Add("labels",Labels.ToHashtable(highcharts));
			if (LegendIndex != null) h.Add("legendIndex",LegendIndex);
			if (MaxSize != null) h.Add("maxSize",MaxSize);
			if (MinSize != null) h.Add("minSize",MinSize);
			if (Ranges != null) h.Add("ranges",Ranges.ToHashtable(highcharts));
			if (SizeBy != null) h.Add("sizeBy",SizeBy);
			if (SizeByAbsoluteValue != null) h.Add("sizeByAbsoluteValue",SizeByAbsoluteValue);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
			if (ZThreshold != null) h.Add("zThreshold",ZThreshold);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}