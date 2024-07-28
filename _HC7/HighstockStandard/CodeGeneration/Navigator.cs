using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class Navigator  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Navigator()
		{
		}	
		

		/// <summary>
		/// Accessibility options for the navigator. Requires theAccessibility module.
		/// </summary>
		public NavigatorAccessibility Accessibility { get; set; }
		 

		/// <summary>
		/// Whether the navigator and scrollbar should adapt to updated datain the base X axis. When loading data async, as in the demo below,this should be `false`. Otherwise new data will trigger navigatorredraw, which will cause unwanted looping. In the demo below, thedata in the navigator is set only once. On navigating, only the mainchart content is updated.
		/// </summary>
		public bool? AdaptToUpdatedData { get; set; }
		 

		/// <summary>
		/// An integer identifying the index to use for the base series, or astring representing the id of the series.**Note**: As of Highcharts 5.0, this is now a deprecated option.Prefer [series.showInNavigator](#plotOptions.series.showInNavigator).
		/// </summary>
		public string BaseSeries { get; set; }
		 

		/// <summary>
		/// An integer identifying the index to use for the base series, or astring representing the id of the series.**Note**: As of Highcharts 5.0, this is now a deprecated option.Prefer [series.showInNavigator](#plotOptions.series.showInNavigator).
		/// </summary>
		public double? BaseSeriesNumber { get; set; }
		 

		/// <summary>
		/// Enable or disable the navigator.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Options for the handles for dragging the zoomed area.
		/// </summary>
		public NavigatorHandles Handles { get; set; }
		 

		/// <summary>
		/// The height of the navigator.
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// The distance from the nearest element, the X axis or X axis labels.
		/// </summary>
		public double? Margin { get; set; }
		 

		/// <summary>
		/// The color of the mask covering the areas of the navigator seriesthat are currently not visible in the main series. The defaultcolor is bluish with an opacity of 0.3 to see the series below.
		/// </summary>
		public string MaskFill { get; set; }
		 

		/// <summary>
		/// Whether the mask should be inside the range marking the zoomedrange, or outside. In Highcharts Stock 1.x it was always `false`.
		/// </summary>
		public bool? MaskInside { get; set; }
		 

		/// <summary>
		/// When the chart is inverted, whether to draw the navigator on theopposite side.
		/// </summary>
		public bool? Opposite { get; set; }
		 

		/// <summary>
		/// The color of the line marking the currently zoomed area in thenavigator.
		/// </summary>
		public string OutlineColor { get; set; }
		 

		/// <summary>
		/// The width of the line marking the currently zoomed area in thenavigator.
		/// </summary>
		public double? OutlineWidth { get; set; }
		 

		/// <summary>
		/// Options for the navigator series. Available options are the sameas any series, documented at [plotOptions](#plotOptions.series)and [series](#series).Unless data is explicitly defined on navigator.series, the datais borrowed from the first series in the chart.Default series options for the navigator series are:```jsseries: {    type: 'areaspline',    fillOpacity: 0.05,    dataGrouping: {        smoothed: true    },    lineWidth: 1,    marker: {        enabled: false    }}```
		/// </summary>
		public Series Series { get; set; }
		 

		/// <summary>
		/// Enable or disable navigator sticking to right, while adding newpoints. If `undefined`, the navigator sticks to the axis maximum onlyif it was already at the maximum prior to adding points.
		/// </summary>
		public bool? StickToMax { get; set; }
		 

		/// <summary>
		/// Options for the navigator X axis. Default series options for thenavigator xAxis are:```jsxAxis: {    tickWidth: 0,    lineWidth: 0,    gridLineWidth: 1,    tickPixelInterval: 200,    labels: {           align: 'left',        style: {            color: '#888'        },        x: 3,        y: -4    }}```
		/// </summary>
		public string XAxis { get; set; }
		 

		/// <summary>
		/// Options for the navigator Y axis. Default series options for thenavigator yAxis are:```jsyAxis: {    gridLineWidth: 0,    startOnTick: false,    endOnTick: false,    minPadding: 0.1,    maxPadding: 0.1,    labels: {        enabled: false    },    title: {        text: null    },    tickWidth: 0}```
		/// </summary>
		public string YAxis { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highstock));
			if (AdaptToUpdatedData != null) h.Add("adaptToUpdatedData",AdaptToUpdatedData);
			if (BaseSeries != null) h.Add("baseSeries",BaseSeries);
			if (BaseSeriesNumber != null) h.Add("baseSeries",BaseSeriesNumber);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Handles != null) h.Add("handles",Handles.ToHashtable(highstock));
			if (Height != null) h.Add("height",Height);
			if (Margin != null) h.Add("margin",Margin);
			if (MaskFill != null) h.Add("maskFill",MaskFill);
			if (MaskInside != null) h.Add("maskInside",MaskInside);
			if (Opposite != null) h.Add("opposite",Opposite);
			if (OutlineColor != null) h.Add("outlineColor",OutlineColor);
			if (OutlineWidth != null) h.Add("outlineWidth",OutlineWidth);
			if (Series != null) h.Add("series",Series.ToHashtable(highstock));
			if (StickToMax != null) h.Add("stickToMax",StickToMax);
			if (XAxis != null) h.Add("xAxis",XAxis);
			if (YAxis != null) h.Add("yAxis",YAxis);
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