using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Maps
{
	public partial class MapPointSeriesData  : BaseObject
	{
		public MapPointSeriesData()
		{
			Color = Color_DefaultValue = "undefined";
			DataLabels = DataLabels_DefaultValue = null;
			Drilldown = Drilldown_DefaultValue = null;
			Events = Events_DefaultValue = new MapPointSeriesDataEvents();
			Id = Id_DefaultValue = null;
			Lat = Lat_DefaultValue = null;
			Lon = Lon_DefaultValue = null;
			Name = Name_DefaultValue = null;
			X = X_DefaultValue = double.MinValue;
			Y = Y_DefaultValue = double.MinValue;
			
		}	
		

		/// <summary>
		/// Individual color for the point. By default the color is either used to denote the value, or pulled from the global <code>colors</code> array.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual data label for each point. The options are the same as the ones for  <a class="internal" href="#plotOptions.series.dataLabels">plotOptions.series.dataLabels</a>
		/// </summary>
		public Object DataLabels { get; set; }
		private Object DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The <code>id</code> of a series in the <a href="#drilldown.series">drilldown.series</a> array to use for a drilldown for this point.
		/// </summary>
		public string Drilldown { get; set; }
		private string Drilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual point events
		/// </summary>
		public MapPointSeriesDataEvents Events { get; set; }
		private MapPointSeriesDataEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the point. This can be used after render time to get a pointer to the point object through <code>chart.get()</code>.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// The latitude of the point. Must be combined with the <code>lon</code> option to work. Overrides <code>x</code> and <code>y</code> values.
		/// </summary>
		public double? Lat { get; set; }
		private double? Lat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The longitude of the point. Must be combined with the <code>lon</code> option to work. Overrides <code>x</code> and <code>y</code> values.
		/// </summary>
		public double? Lon { get; set; }
		private double? Lon_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the point as shown in the legend, tooltip, dataLabel etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x coordinate of the point in terms of the map path coordinates.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x coordinate of the point in terms of the map path coordinates.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DataLabels != DataLabels_DefaultValue) h.Add("dataLabels",DataLabels);
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Lat != Lat_DefaultValue) h.Add("lat",Lat);
			if (Lon != Lon_DefaultValue) h.Add("lon",Lon);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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