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
	public partial class VectorSeriesData  : BaseObject
	{
		public VectorSeriesData()
		{
			Length = Length_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Drilldown = Drilldown_DefaultValue = "";
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "undefined";
			ColorIndex = ColorIndex_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = "";
			Description = Description_DefaultValue = "undefined";
			Id = Id_DefaultValue = "null";
			Labelrank = Labelrank_DefaultValue = null;
			Name = Name_DefaultValue = "";
			Selected = Selected_DefaultValue = false;
			X = X_DefaultValue = double.MinValue;
			Y = Y_DefaultValue = double.MinValue;
			Events = Events_DefaultValue = new VectorSeriesDataEvents();
			Marker = Marker_DefaultValue = new VectorSeriesDataMarker();
			
		}	
		

		/// <summary>
		/// The length of the vector. The rendered length will relate to the`vectorLength` setting.
		/// </summary>
		public double? Length { get; set; }
		private double? Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vector direction in degrees, where 0 is north (pointing towards south).
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

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
		public VectorSeriesDataLabels DataLabels { get; set; }
		private VectorSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

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
		public VectorSeriesDataEvents Events { get; set; }
		private VectorSeriesDataEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public VectorSeriesDataMarker Marker { get; set; }
		private VectorSeriesDataMarker Marker_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Length != Length_DefaultValue) h.Add("length",Length);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (DataLabels != DataLabels_DefaultValue) h.Add("dataLabels",DataLabels);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labelrank != Labelrank_DefaultValue) h.Add("labelrank",Labelrank);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			

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