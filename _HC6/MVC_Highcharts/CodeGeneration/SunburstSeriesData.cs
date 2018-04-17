using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class SunburstSeriesData  : BaseObject
	{
		public SunburstSeriesData()
		{
			Value = Value_DefaultValue = null;
			Sliced = Sliced_DefaultValue = false;
			Name = Name_DefaultValue = "undefined";
			Weight = Weight_DefaultValue = null;
			Drilldown = Drilldown_DefaultValue = "";
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "undefined";
			ColorIndex = ColorIndex_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = new SunburstSeriesDataLabels();
			Description = Description_DefaultValue = "undefined";
			Id = Id_DefaultValue = "null";
			Labelrank = Labelrank_DefaultValue = null;
			Selected = Selected_DefaultValue = false;
			Events = Events_DefaultValue = new SunburstSeriesDataEvents();
			PointPadding = PointPadding_DefaultValue = null;
			Parent = Parent_DefaultValue = "undefined";
			ColorValue = ColorValue_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The value of the point, resulting in a relative area of the pointin the sunburst.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display a slice offset from the center. When a sunburst point is sliced, its children are also offset.
		/// </summary>
		public bool? Sliced { get; set; }
		private bool? Sliced_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name decides the text for a word.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weighting of a word. The weight decides the relative size of a wordcompared to the rest of the collection.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `id` of a series in the [drilldown.series](#drilldown.series)array to use for a drilldown for this point.
		/// </summary>
		public string Drilldown { get; set; }
		private string Drilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional, individual class name for the data point's graphicrepresentation.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual color for the point. By default the color is pulled fromthe global `colors` array.In styled mode, the `color` option doesn't take effect. Instead, use `colorIndex`.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// A specific color index to use for the point, so its graphic representationsare given the class name `highcharts-color-{n}`. In styled mode this willchange the color of the graphic. In non-styled mode, the color by is set bythe `fill` attribute, so the change in class name won't have a visual effectby default.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual data label for each point. The options are the same asthe ones for [plotOptions.series.dataLabels](#plotOptions.series.dataLabels)
		/// </summary>
		public SunburstSeriesDataLabels DataLabels { get; set; }
		private SunburstSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// A description of the point to add to the screen reader informationabout the point. Requires the Accessibility module.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

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
		/// Individual point events
		/// </summary>
		public SunburstSeriesDataEvents Events { get; set; }
		private SunburstSeriesDataEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Point padding for a single point.
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Only for treemap. Use this option to build a tree structure. Thevalue should be the id of the point which is the parent. If no pointshas a matching id, or this option is undefined, then the parent willbe set to the root.
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// Serves a purpose only if a `colorAxis` object is defined in the chartoptions. This value will decide which color the point gets from thescale of the colorAxis.
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Sliced != Sliced_DefaultValue) h.Add("sliced",Sliced);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labelrank != Labelrank_DefaultValue) h.Add("labelrank",Labelrank);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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