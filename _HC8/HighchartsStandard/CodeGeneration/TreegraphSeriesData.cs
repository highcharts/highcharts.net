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
	public partial class TreegraphSeriesData  : BaseObject
	{
		Hashtable h = new Hashtable();

		public TreegraphSeriesData()
		{
			Accessibility = Accessibility_DefaultValue = new TreegraphSeriesDataAccessibility();
			ClassName = ClassName_DefaultValue = "";
			CollapseButton = CollapseButton_DefaultValue = "";
			Collapsed = Collapsed_DefaultValue = null;
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			ColorValue = ColorValue_DefaultValue = null;
			Custom = Custom_DefaultValue = new Hashtable();
			Description = Description_DefaultValue = "";
			DragDrop = DragDrop_DefaultValue = new TreegraphSeriesDataDragDrop();
			Drilldown = Drilldown_DefaultValue = "";
			Events = Events_DefaultValue = new TreegraphSeriesDataEvents();
			Id = Id_DefaultValue = "";
			Labelrank = Labelrank_DefaultValue = null;
			Marker = Marker_DefaultValue = new TreegraphSeriesDataMarker();
			Name = Name_DefaultValue = "";
			Parent = Parent_DefaultValue = "";
			PointPadding = PointPadding_DefaultValue = null;
			Selected = Selected_DefaultValue = false;
			Value = Value_DefaultValue = null;
			X = X_DefaultValue = double.MinValue;
			Y = Y_DefaultValue = double.MinValue;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Accessibility options for a data point.
		/// </summary>
		public TreegraphSeriesDataAccessibility Accessibility { get; set; }
		private TreegraphSeriesDataAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional, individual class name for the data point's graphicrepresentation.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options used for button, which toggles the collapse status of the node.
		/// </summary>
		public string CollapseButton { get; set; }
		private string CollapseButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// If point's children should be initially hidden
		/// </summary>
		public bool? Collapsed { get; set; }
		private bool? Collapsed_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual color for the point. By default the color is pulled fromthe global `colors` array.In styled mode, the `color` option doesn't take effect. Instead, use`colorIndex`.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// A specific color index to use for the point, so its graphic representationsare given the class name `highcharts-color-{n}`. In styled mode this willchange the color of the graphic. In non-styled mode, the color is set by the`fill` attribute, so the change in class name won't have a visual effect bydefault.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Serves a purpose only if a `colorAxis` object is defined in the chartoptions. This value will decide which color the point gets from thescale of the colorAxis.
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customized functionality.Here you can add additional data for your own event callbacks and formattercallbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		private Hashtable Custom_DefaultValue { get; set; }
		 

		/// <summary>
		/// A description of the point to add to the screen reader informationabout the point.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point specific options for the draggable-points module. Overrides options on`series.dragDrop`.
		/// </summary>
		public TreegraphSeriesDataDragDrop DragDrop { get; set; }
		private TreegraphSeriesDataDragDrop DragDrop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `id` of a series in the [drilldown.series](#drilldown.series) array touse for a drilldown for this point.
		/// </summary>
		public string Drilldown { get; set; }
		private string Drilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// The individual point events.
		/// </summary>
		public TreegraphSeriesDataEvents Events { get; set; }
		private TreegraphSeriesDataEvents Events_DefaultValue { get; set; }
		 

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
		/// Options for the point markers of line-like series.
		/// </summary>
		public TreegraphSeriesDataMarker Marker { get; set; }
		private TreegraphSeriesDataMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the point as shown in the legend, tooltip, dataLabels, etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// Only for treemap. Use this option to build a tree structure. Thevalue should be the id of the point which is the parent. If no pointshas a matching id, or this option is undefined, then the parent willbe set to the root.
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point padding for a single point.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the data point is selected initially.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a color controled by optionsas set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

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

			if (Accessibility.IsDirty(highcharts)) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (CollapseButton != CollapseButton_DefaultValue) h.Add("collapseButton",CollapseButton);
			if (Collapsed != Collapsed_DefaultValue) h.Add("collapsed",Collapsed);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			if (Custom != Custom_DefaultValue) h.Add("custom",Custom);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (DragDrop.IsDirty(highcharts)) h.Add("dragDrop",DragDrop.ToHashtable(highcharts));
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (Events.IsDirty(highcharts)) h.Add("events",Events.ToHashtable(highcharts));
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labelrank != Labelrank_DefaultValue) h.Add("labelrank",Labelrank);
			if (Marker.IsDirty(highcharts)) h.Add("marker",Marker.ToHashtable(highcharts));
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
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