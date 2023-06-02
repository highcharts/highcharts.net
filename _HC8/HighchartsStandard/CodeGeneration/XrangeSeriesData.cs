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
			Accessibility = Accessibility_DefaultValue = new XrangeSeriesDataAccessibility();
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			Connect = Connect_DefaultValue = new XrangeSeriesDataConnect();
			ConnectString = ConnectString_DefaultValue = "null";
			Custom = Custom_DefaultValue = new Hashtable();
			DataLabels = DataLabels_DefaultValue = new XrangeSeriesDataLabels();
			Description = Description_DefaultValue = "";
			DragDrop = DragDrop_DefaultValue = new XrangeSeriesDataDragDrop();
			Drilldown = Drilldown_DefaultValue = "";
			Events = Events_DefaultValue = new XrangeSeriesDataEvents();
			Id = Id_DefaultValue = "";
			Labelrank = Labelrank_DefaultValue = null;
			Marker = Marker_DefaultValue = new XrangeSeriesDataMarker();
			Name = Name_DefaultValue = "";
			PartialFill = PartialFill_DefaultValue = new XrangeSeriesDataPartialFill();
			Selected = Selected_DefaultValue = false;
			X = X_DefaultValue = double.MinValue;
			X2 = X2_DefaultValue = null;
			Y = Y_DefaultValue = double.MinValue;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Accessibility options for a data point.
		/// </summary>
		public XrangeSeriesDataAccessibility Accessibility { get; set; }
		private XrangeSeriesDataAccessibility Accessibility_DefaultValue { get; set; }
		 

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
		/// Connect to a point. This option can be either a string, referring to the IDof another point, or an object, or an array of either. If the option is anarray, each element defines a connection.
		/// </summary>
		public XrangeSeriesDataConnect Connect { get; set; }
		private XrangeSeriesDataConnect Connect_DefaultValue { get; set; }
		 

		/// <summary>
		/// Connect to a point. This option can be either a string, referring to the IDof another point, or an object, or an array of either. If the option is anarray, each element defines a connection.
		/// </summary>
		public string ConnectString { get; set; }
		private string ConnectString_DefaultValue { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customized functionality.Here you can add additional data for your own event callbacks and formattercallbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		private Hashtable Custom_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual data label for each point. The options are the same asthe ones for [plotOptions.series.dataLabels](#plotOptions.series.dataLabels).
		/// </summary>
		public XrangeSeriesDataLabels DataLabels { get; set; }
		private XrangeSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// A description of the point to add to the screen reader informationabout the point.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point specific options for the draggable-points module. Overrides options on`series.dragDrop`.
		/// </summary>
		public XrangeSeriesDataDragDrop DragDrop { get; set; }
		private XrangeSeriesDataDragDrop DragDrop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `id` of a series in the [drilldown.series](#drilldown.series) array touse for a drilldown for this point.
		/// </summary>
		public string Drilldown { get; set; }
		private string Drilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// The individual point events.
		/// </summary>
		public XrangeSeriesDataEvents Events { get; set; }
		private XrangeSeriesDataEvents Events_DefaultValue { get; set; }
		 

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
		public XrangeSeriesDataMarker Marker { get; set; }
		private XrangeSeriesDataMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the point as shown in the legend, tooltip, dataLabels, etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// A partial fill for each point, typically used to visualize how much ofa task is performed. The partial fill object can be set either on seriesor point level.
		/// </summary>
		public XrangeSeriesDataPartialFill PartialFill { get; set; }
		private XrangeSeriesDataPartialFill PartialFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the data point is selected initially.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// The starting X value of the range point.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The ending X value of the range point.
		/// </summary>
		public double? X2 { get; set; }
		private double? X2_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Y value of the range point.
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
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Connect.IsDirty(highcharts)) h.Add("connect",Connect.ToHashtable(highcharts));
			if (ConnectString != ConnectString_DefaultValue) h.Add("connect",ConnectString);
			if (Custom != Custom_DefaultValue) h.Add("custom",Custom);
			if (DataLabels.IsDirty(highcharts)) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (DragDrop.IsDirty(highcharts)) h.Add("dragDrop",DragDrop.ToHashtable(highcharts));
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (Events.IsDirty(highcharts)) h.Add("events",Events.ToHashtable(highcharts));
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labelrank != Labelrank_DefaultValue) h.Add("labelrank",Labelrank);
			if (Marker.IsDirty(highcharts)) h.Add("marker",Marker.ToHashtable(highcharts));
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (PartialFill.IsDirty(highcharts)) h.Add("partialFill",PartialFill.ToHashtable(highcharts));
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (X != X_DefaultValue) h.Add("x",X);
			if (X2 != X2_DefaultValue) h.Add("x2",X2);
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