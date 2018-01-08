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
	public partial class BoxplotSeriesData  : BaseObject
	{
		public BoxplotSeriesData()
		{
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			Median = Median_DefaultValue = null;
			Q1 = Q1_DefaultValue = null;
			Q3 = Q3_DefaultValue = null;
			Drilldown = Drilldown_DefaultValue = "";
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "undefined";
			ColorIndex = ColorIndex_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = new BoxplotSeriesDataLabels();
			Description = Description_DefaultValue = "undefined";
			Id = Id_DefaultValue = "null";
			Labelrank = Labelrank_DefaultValue = null;
			Name = Name_DefaultValue = "";
			Selected = Selected_DefaultValue = false;
			X = X_DefaultValue = double.MinValue;
			Y = Y_DefaultValue = double.MinValue;
			Events = Events_DefaultValue = new BoxplotSeriesDataEvents();
			
		}	
		

		/// <summary>
		/// The `high` value for each data point, signifying the highest valuein the sample set. The top whisker is drawn here.
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

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
		/// Styled mode only. A specific color index to use for the point, so itsgraphic representations are given the class name`highcharts-color-{n}`.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual data label for each point. The options are the same asthe ones for [plotOptions.series.dataLabels](#plotOptions.series.dataLabels)
		/// </summary>
		public BoxplotSeriesDataLabels DataLabels { get; set; }
		private BoxplotSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

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
		/// The name of the point as shown in the legend, tooltip, dataLabeletc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

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
		 

		/// <summary>
		/// The y value of the point.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual point events
		/// </summary>
		public BoxplotSeriesDataEvents Events { get; set; }
		private BoxplotSeriesDataEvents Events_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (Median != Median_DefaultValue) h.Add("median",Median);
			if (Q1 != Q1_DefaultValue) h.Add("q1",Q1);
			if (Q3 != Q3_DefaultValue) h.Add("q3",Q3);
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labelrank != Labelrank_DefaultValue) h.Add("labelrank",Labelrank);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			

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