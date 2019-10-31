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
	public partial class FlagsSeriesData  : BaseObject
	{
		public FlagsSeriesData()
		{
			Accessibility = Accessibility_DefaultValue = new FlagsSeriesDataAccessibility();
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			Description = Description_DefaultValue = "";
			DragDrop = DragDrop_DefaultValue = new FlagsSeriesDataDragDrop();
			Drilldown = Drilldown_DefaultValue = "";
			Events = Events_DefaultValue = new FlagsSeriesDataEvents();
			FillColor = FillColor_DefaultValue = "";
			Id = Id_DefaultValue = "";
			Labelrank = Labelrank_DefaultValue = null;
			Selected = Selected_DefaultValue = false;
			Text = Text_DefaultValue = "";
			Title = Title_DefaultValue = "";
			X = X_DefaultValue = double.MinValue;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public FlagsSeriesDataAccessibility Accessibility { get; set; }
		private FlagsSeriesDataAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional, individual class name for the data point's graphicrepresentation.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

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
		/// A description of the point to add to the screen reader informationabout the point. Requires the Accessibility module.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point specific options for the draggable-points module. Overrides options on`series.dragDrop`.Requires the `draggable-points` module.
		/// </summary>
		public FlagsSeriesDataDragDrop DragDrop { get; set; }
		private FlagsSeriesDataDragDrop DragDrop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `id` of a series in the [drilldown.series](#drilldown.series) array touse for a drilldown for this point.
		/// </summary>
		public string Drilldown { get; set; }
		private string Drilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual point events
		/// </summary>
		public FlagsSeriesDataEvents Events { get; set; }
		private FlagsSeriesDataEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of an individual flag. By default it inherits fromthe series color.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

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
		/// Whether the data point is selected initially.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// The longer text to be shown in the flag's tooltip.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// The short text to be shown on the flag.
		/// </summary>
		public string Title { get; set; }
		private string Title_DefaultValue { get; set; }
		 

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
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (DragDrop.IsDirty()) h.Add("dragDrop",DragDrop.ToHashtable());
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (Events != Events_DefaultValue) h.Add("events",Events);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labelrank != Labelrank_DefaultValue) h.Add("labelrank",Labelrank);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Title != Title_DefaultValue) h.Add("title",Title);
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