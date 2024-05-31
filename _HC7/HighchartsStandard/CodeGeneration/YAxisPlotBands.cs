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
	public partial class YAxisPlotBands  : BaseObject
	{
		Hashtable h = new Hashtable();

		public YAxisPlotBands()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Flag to decide if plotBand should be rendered across all panes.
		/// </summary>
		public bool? AcrossPanes { get; set; }
		 

		/// <summary>
		/// Border color for the plot band. Also requires `borderWidth` to be set.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// Border width for the plot band. Also requires `borderColor` to be set.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// A custom class name, in addition to the default `highcharts-plot-band`,to apply to each individual band.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// The color of the plot band.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// An object defining mouse events for the plot band. Supported propertiesare `click`, `mouseover`, `mouseout`, `mousemove`.
		/// </summary>
		public Object Events { get; set; }
		 

		/// <summary>
		/// The start position of the plot band in axis units.
		/// </summary>
		public double? From { get; set; }
		 

		/// <summary>
		/// An id used for identifying the plot band in Axis.removePlotBand.
		/// </summary>
		public string Id { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the inner radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.By default, the inner radius is controlled by the [thickness](#yAxis.plotBands.thickness) option.
		/// </summary>
		public string InnerRadius { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the inner radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.By default, the inner radius is controlled by the [thickness](#yAxis.plotBands.thickness) option.
		/// </summary>
		public double? InnerRadiusNumber { get; set; }
		 

		/// <summary>
		/// Text labels for the plot bands
		/// </summary>
		public YAxisPlotBandsLabel Label { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the outer radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.
		/// </summary>
		public string OuterRadius { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the outer radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.
		/// </summary>
		public double? OuterRadiusNumber { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option sets the width of the plot bandstretching along the perimeter. It can be given as a percentagestring, like `"10%"`, or as a pixel number, like `10`. The defaultvalue 10 is the same as the default [tickLength](#yAxis.tickLength),thus making the plot band act as a background for the tick markers.
		/// </summary>
		public string Thickness { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option sets the width of the plot bandstretching along the perimeter. It can be given as a percentagestring, like `"10%"`, or as a pixel number, like `10`. The defaultvalue 10 is the same as the default [tickLength](#yAxis.tickLength),thus making the plot band act as a background for the tick markers.
		/// </summary>
		public double? ThicknessNumber { get; set; }
		 

		/// <summary>
		/// The end position of the plot band in axis units.
		/// </summary>
		public double? To { get; set; }
		 

		/// <summary>
		/// The z index of the plot band within the chart, relative to otherelements. Using the same z index as another element may giveunpredictable results, as the last rendered element will be on top.Values from 0 to 20 make sense.
		/// </summary>
		public double? ZIndex { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (AcrossPanes != null) h.Add("acrossPanes",AcrossPanes);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (ClassName != null) h.Add("className",ClassName);
			if (Color != null) h.Add("color",Color);
			if (Events != null) h.Add("events",Events);
			if (From != null) h.Add("from",From);
			if (Id != null) h.Add("id",Id);
			if (InnerRadius != null) h.Add("innerRadius",InnerRadius);
			if (InnerRadiusNumber != null) h.Add("innerRadius",InnerRadiusNumber);
			if (Label != null) h.Add("label",Label.ToHashtable(highcharts));
			if (OuterRadius != null) h.Add("outerRadius",OuterRadius);
			if (OuterRadiusNumber != null) h.Add("outerRadius",OuterRadiusNumber);
			if (Thickness != null) h.Add("thickness",Thickness);
			if (ThicknessNumber != null) h.Add("thickness",ThicknessNumber);
			if (To != null) h.Add("to",To);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
			if (CustomFields.Count > 0)
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