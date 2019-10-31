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
	public partial class OhlcSeriesData  : BaseObject
	{
		public OhlcSeriesData()
		{
			Accessibility = Accessibility_DefaultValue = new OhlcSeriesDataAccessibility();
			ClassName = ClassName_DefaultValue = "";
			Close = Close_DefaultValue = null;
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = new OhlcSeriesDataLabels();
			Description = Description_DefaultValue = "";
			DragDrop = DragDrop_DefaultValue = new OhlcSeriesDataDragDrop();
			Drilldown = Drilldown_DefaultValue = "";
			Events = Events_DefaultValue = new OhlcSeriesDataEvents();
			High = High_DefaultValue = null;
			Id = Id_DefaultValue = "";
			Labelrank = Labelrank_DefaultValue = null;
			Low = Low_DefaultValue = null;
			Name = Name_DefaultValue = "";
			Open = Open_DefaultValue = null;
			Selected = Selected_DefaultValue = false;
			X = X_DefaultValue = double.MinValue;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public OhlcSeriesDataAccessibility Accessibility { get; set; }
		private OhlcSeriesDataAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional, individual class name for the data point's graphicrepresentation.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The closing value of each data point.
		/// </summary>
		public double? Close { get; set; }
		private double? Close_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual color for the point. By default the color is pulled fromthe global `colors` array.In styled mode, the `color` option doesn't take effect. Instead, use`colorIndex`.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// A specific color index to use for the point, so its graphic representationsare given the class name `highcharts-color-{n}`. In styled mode this willchange the color of the graphic. In non-styled mode, the color by is set bythe `fill` attribute, so the change in class name won't have a visual effectby default.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual data label for each point. The options are the same asthe ones for [plotOptions.series.dataLabels](#plotOptions.series.dataLabels).
		/// </summary>
		public OhlcSeriesDataLabels DataLabels { get; set; }
		private OhlcSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// A description of the point to add to the screen reader informationabout the point. Requires the Accessibility module.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point specific options for the draggable-points module. Overrides options on`series.dragDrop`.Requires the `draggable-points` module.
		/// </summary>
		public OhlcSeriesDataDragDrop DragDrop { get; set; }
		private OhlcSeriesDataDragDrop DragDrop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `id` of a series in the [drilldown.series](#drilldown.series) array touse for a drilldown for this point.
		/// </summary>
		public string Drilldown { get; set; }
		private string Drilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual point events
		/// </summary>
		public OhlcSeriesDataEvents Events { get; set; }
		private OhlcSeriesDataEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// The high or maximum value for each data point.
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
		/// The low or minimum value for each data point.
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the point as shown in the legend, tooltip, dataLabelsetc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opening value of each data point.
		/// </summary>
		public double? Open { get; set; }
		private double? Open_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the data point is selected initially.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x value of the point. For datetime axes, the X value is the timestampin milliseconds since 1970.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Accessibility.IsDirty()) h.Add("accessibility",Accessibility.ToHashtable());
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Close != Close_DefaultValue) h.Add("close",Close);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (DragDrop.IsDirty()) h.Add("dragDrop",DragDrop.ToHashtable());
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (Events != Events_DefaultValue) h.Add("events",Events);
			if (High != High_DefaultValue) h.Add("high",High);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labelrank != Labelrank_DefaultValue) h.Add("labelrank",Labelrank);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Open != Open_DefaultValue) h.Add("open",Open);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (X != X_DefaultValue) h.Add("x",X);
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
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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