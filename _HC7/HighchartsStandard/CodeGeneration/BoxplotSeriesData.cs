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
	public partial class BoxplotSeriesData  : BaseObject
	{
		Hashtable h = new Hashtable();

		public BoxplotSeriesData()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Accessibility options for a data point.
		/// </summary>
		public BoxplotSeriesDataAccessibility Accessibility { get; set; }
		private BoxplotSeriesDataAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash style of the box.
		/// </summary>
		public Hashtable BoxDashStyle { get; set; }
		private Hashtable BoxDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional, individual class name for the data point's graphicrepresentation. Changes to a point's color will also be reflected in achart's legend and tooltip.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual color for the point. By default the color is pulled fromthe global `colors` array.In styled mode, the `color` option doesn't take effect. Instead, use`colorIndex`.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// A specific color index to use for the point, so its graphic representationsare given the class name `highcharts-color-{n}`. In styled mode this willchange the color of the graphic. In non-styled mode, the color is set by the`fill` attribute, so the change in class name won't have a visual effect bydefault.Since v11, CSS variables on the form `--highcharts-color-{n}` make changingthe color scheme very convenient.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customized functionality.Here you can add additional data for your own event callbacks and formattercallbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		private Hashtable Custom_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual data label for each point. The options are the same asthe ones for [plotOptions.series.dataLabels](#plotOptions.series.dataLabels).
		/// </summary>
		public BoxplotSeriesDataLabels DataLabels { get; set; }
		private BoxplotSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// A description of the point to add to the screen reader informationabout the point.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point specific options for the draggable-points module. Overrides optionson `series.dragDrop`.
		/// </summary>
		public BoxplotSeriesDataDragDrop DragDrop { get; set; }
		private BoxplotSeriesDataDragDrop DragDrop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `id` of a series in the [drilldown.series](#drilldown.series) array touse for a drilldown for this point.
		/// </summary>
		public string Drilldown { get; set; }
		private string Drilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// The individual point events.
		/// </summary>
		public BoxplotSeriesDataEvents Events { get; set; }
		private BoxplotSeriesDataEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `high` value for each data point, signifying the highest valuein the sample set. The top whisker is drawn here.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the point. This can be used after render time to get apointer to the point object through `chart.get()`.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// The rank for this point's data label in case of collision. If twodata labels are about to overlap, only the one with the highest `labelrank`will be drawn.
		/// </summary>
		public double? Labelrank { get; set; }
		private double? Labelrank_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `low` value for each data point, signifying the lowest valuein the sample set. The bottom whisker is drawn here.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The median for each data point. This is drawn as a line through themiddle area of the box.
		/// </summary>
		public double? Median { get; set; }
		private double? Median_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash style of the median.
		/// </summary>
		public Hashtable MedianDashStyle { get; set; }
		private Hashtable MedianDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the point as shown in the legend, tooltip, dataLabels, etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lower quartile for each data point. This is the bottom of thebox.
		/// </summary>
		public double? Q1 { get; set; }
		private double? Q1_DefaultValue { get; set; }
		 

		/// <summary>
		/// The higher quartile for each data point. This is the top of the box.
		/// </summary>
		public double? Q3 { get; set; }
		private double? Q3_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the data point is selected initially.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash style of the stem.
		/// </summary>
		public Hashtable StemDashStyle { get; set; }
		private Hashtable StemDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dash style of the whiskers.
		/// </summary>
		public Hashtable WhiskerDashStyle { get; set; }
		private Hashtable WhiskerDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x value of the point. For datetime axes, the X value is the timestampin milliseconds since 1970.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y value of the point.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (BoxDashStyle != null) h.Add("boxDashStyle",BoxDashStyle);
			if (ClassName != null) h.Add("className",ClassName);
			if (Color != null) h.Add("color",Color);
			if (ColorIndex != null) h.Add("colorIndex",ColorIndex);
			if (Custom != null) h.Add("custom",Custom);
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (Description != null) h.Add("description",Description);
			if (DragDrop != null) h.Add("dragDrop",DragDrop.ToHashtable(highcharts));
			if (Drilldown != null) h.Add("drilldown",Drilldown);
			if (Events != null) h.Add("events",Events.ToHashtable(highcharts));
			if (High != null) h.Add("high",High);
			if (Id != null) h.Add("id",Id);
			if (Labelrank != null) h.Add("labelrank",Labelrank);
			if (Low != null) h.Add("low",Low);
			if (Median != null) h.Add("median",Median);
			if (MedianDashStyle != null) h.Add("medianDashStyle",MedianDashStyle);
			if (Name != null) h.Add("name",Name);
			if (Q1 != null) h.Add("q1",Q1);
			if (Q3 != null) h.Add("q3",Q3);
			if (Selected != null) h.Add("selected",Selected);
			if (StemDashStyle != null) h.Add("stemDashStyle",StemDashStyle);
			if (WhiskerDashStyle != null) h.Add("whiskerDashStyle",WhiskerDashStyle);
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}