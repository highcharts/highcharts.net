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
	public partial class XAxisPlotBands  : BaseObject
	{
		Hashtable h = new Hashtable();

		public XAxisPlotBands()
		{
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
		/// Border radius for the plot band. Applies only to gauges. Can be a pixelvalue or a percentage, for example `50%`.
		/// </summary>
		public string BorderRadius { get; set; }
		 

		/// <summary>
		/// Border radius for the plot band. Applies only to gauges. Can be a pixelvalue or a percentage, for example `50%`.
		/// </summary>
		public double? BorderRadiusNumber { get; set; }
		 

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
		/// Text labels for the plot bands
		/// </summary>
		public XAxisPlotBandsLabel Label { get; set; }
		 

		/// <summary>
		/// The end position of the plot band in axis units.
		/// </summary>
		public double? To { get; set; }
		 

		/// <summary>
		/// The z index of the plot band within the chart, relative to otherelements. Using the same z index as another element may giveunpredictable results, as the last rendered element will be on top.Values from 0 to 20 make sense.
		/// </summary>
		public double? ZIndex { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (AcrossPanes != null) h.Add("acrossPanes",AcrossPanes);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (BorderRadiusNumber != null) h.Add("borderRadius",BorderRadiusNumber);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (ClassName != null) h.Add("className",ClassName);
			if (Color != null) h.Add("color",Color);
			if (Events != null) h.Add("events",Events);
			if (From != null) h.Add("from",From);
			if (Id != null) h.Add("id",Id);
			if (Label != null) h.Add("label",Label.ToHashtable(highcharts));
			if (To != null) h.Add("to",To);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
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