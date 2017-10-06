using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class VectorSeriesData  : BaseObject
	{
		public VectorSeriesData()
		{
			Length = Length_DefaultValue = null;
			Direction = Direction_DefaultValue = null;
			Color = Color_DefaultValue = "undefined";
			DataLabels = DataLabels_DefaultValue = new VectorSeriesDataLabels();
			Description = Description_DefaultValue = "undefined";
			Id = Id_DefaultValue = "null";
			Labelrank = Labelrank_DefaultValue = null;
			Name = Name_DefaultValue = null;
			Selected = Selected_DefaultValue = false;
			X = X_DefaultValue = double.MinValue;
			Y = Y_DefaultValue = double.MinValue;
			Events = Events_DefaultValue = new VectorSeriesDataEvents();
			Marker = Marker_DefaultValue = new VectorSeriesDataMarker();
			
		}	
		

		/// <summary>
		/// <p>The length of the vector. The rendered length will relate to the<code>vectorLength</code> setting.</p>
		/// </summary>
		public double? Length { get; set; }
		private double? Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The vector direction in degrees, where 0 is north (pointing towards south).</p>
		/// </summary>
		public double? Direction { get; set; }
		private double? Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Individual color for the point. By default the color is pulled fromthe global <code>colors</code> array.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Individual data label for each point. The options are the same asthe ones for <a href="#plotOptions.series.dataLabels">plotOptions.series.dataLabels</a></p>
		/// </summary>
		public VectorSeriesDataLabels DataLabels { get; set; }
		private VectorSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A description of the point to add to the screen reader informationabout the point. Requires the Accessibility module.</p>
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An id for the point. This can be used after render time to get apointer to the point object through <code>chart.get()</code>.</p>
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The rank for this point&#39;s data label in case of collision. If twodata labels are about to overlap, only the one with the highest <code>labelrank</code>will be drawn.</p>
		/// </summary>
		public double? Labelrank { get; set; }
		private double? Labelrank_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The name of the point as shown in the legend, tooltip, dataLabeletc.</p>
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether the data point is selected initially.</p>
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The x value of the point. For datetime axes, the X value is the timestampin milliseconds since 1970.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The y value of the point.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Individual point events</p>
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
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
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