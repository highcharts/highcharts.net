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
	public partial class XrangeSeriesData  : BaseObject
	{
		Hashtable h = new Hashtable();

		public XrangeSeriesData()
		{
		}	
		

		/// <summary>
		/// Accessibility options for a data point.
		/// </summary>
		public XrangeSeriesDataAccessibility Accessibility { get; set; }
		 

		/// <summary>
		/// An additional, individual class name for the data point's graphicrepresentation. Changes to a point's color will also be reflected in achart's legend and tooltip.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// Individual color for the point. By default the color is pulled fromthe global `colors` array.In styled mode, the `color` option doesn't take effect. Instead, use`colorIndex`.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// A specific color index to use for the point, so its graphic representationsare given the class name `highcharts-color-{n}`. In styled mode this willchange the color of the graphic. In non-styled mode, the color is set by the`fill` attribute, so the change in class name won't have a visual effect bydefault.Since v11, CSS variables on the form `--highcharts-color-{n}` make changingthe color scheme very convenient.
		/// </summary>
		public double? ColorIndex { get; set; }
		 

		/// <summary>
		/// Connect to a point. This option can be either a string, referring to the IDof another point, or an object, or an array of either. If the option is anarray, each element defines a connection.
		/// </summary>
		public XrangeSeriesDataConnect Connect { get; set; }
		 

		/// <summary>
		/// Connect to a point. This option can be either a string, referring to the IDof another point, or an object, or an array of either. If the option is anarray, each element defines a connection.
		/// </summary>
		public string ConnectString { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customized functionality.Here you can add additional data for your own event callbacks and formattercallbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		 

		/// <summary>
		/// Individual data label for each point. The options are the same asthe ones for [plotOptions.series.dataLabels](#plotOptions.series.dataLabels).
		/// </summary>
		public XrangeSeriesDataLabels DataLabels { get; set; }
		 

		/// <summary>
		/// A description of the point to add to the screen reader informationabout the point.
		/// </summary>
		public string Description { get; set; }
		 

		/// <summary>
		/// Point specific options for the draggable-points module. Overrides optionson `series.dragDrop`.
		/// </summary>
		public XrangeSeriesDataDragDrop DragDrop { get; set; }
		 

		/// <summary>
		/// The `id` of a series in the [drilldown.series](#drilldown.series) array touse for a drilldown for this point.
		/// </summary>
		public string Drilldown { get; set; }
		 

		/// <summary>
		/// The individual point events.
		/// </summary>
		public XrangeSeriesDataEvents Events { get; set; }
		 

		/// <summary>
		/// An id for the point. This can be used after render time to get apointer to the point object through `chart.get()`.
		/// </summary>
		public string Id { get; set; }
		 

		/// <summary>
		/// The rank for this point's data label in case of collision. If twodata labels are about to overlap, only the one with the highest `labelrank`will be drawn.
		/// </summary>
		public double? Labelrank { get; set; }
		 

		/// <summary>
		/// Options for the point markers of line-like series.
		/// </summary>
		public XrangeSeriesDataMarker Marker { get; set; }
		 

		/// <summary>
		/// The name of the point as shown in the legend, tooltip, dataLabels, etc.
		/// </summary>
		public string Name { get; set; }
		 

		/// <summary>
		/// A partial fill for each point, typically used to visualize how much ofa task is performed. The partial fill object can be set either on seriesor point level.
		/// </summary>
		public XrangeSeriesDataPartialFill PartialFill { get; set; }
		 

		/// <summary>
		/// Whether the data point is selected initially.
		/// </summary>
		public bool? Selected { get; set; }
		 

		/// <summary>
		/// The starting X value of the range point.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The ending X value of the range point.
		/// </summary>
		public double? X2 { get; set; }
		 

		/// <summary>
		/// The Y value of the range point.
		/// </summary>
		public double? Y { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (ClassName != null) h.Add("className",ClassName);
			if (Color != null) h.Add("color",Color);
			if (ColorIndex != null) h.Add("colorIndex",ColorIndex);
			if (Connect != null) h.Add("connect",Connect.ToHashtable(highcharts));
			if (ConnectString != null) h.Add("connect",ConnectString);
			if (Custom != null) h.Add("custom",Custom);
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (Description != null) h.Add("description",Description);
			if (DragDrop != null) h.Add("dragDrop",DragDrop.ToHashtable(highcharts));
			if (Drilldown != null) h.Add("drilldown",Drilldown);
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
			if (Id != null) h.Add("id",Id);
			if (Labelrank != null) h.Add("labelrank",Labelrank);
			if (Marker != null) h.Add("marker",Marker.ToHashtable(highcharts));
			if (Name != null) h.Add("name",Name);
			if (PartialFill != null) h.Add("partialFill",PartialFill.ToHashtable(highcharts));
			if (Selected != null) h.Add("selected",Selected);
			if (X != null) h.Add("x",X);
			if (X2 != null) h.Add("x2",X2);
			if (Y != null) h.Add("y",Y);
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