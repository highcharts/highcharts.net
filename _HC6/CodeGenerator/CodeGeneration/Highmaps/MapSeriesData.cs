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
	public partial class MapSeriesData  : BaseObject
	{
		public MapSeriesData()
		{
			Color = Color_DefaultValue = "undefined";
			DataLabels = DataLabels_DefaultValue = null;
			Drilldown = Drilldown_DefaultValue = null;
			Events = Events_DefaultValue = new MapSeriesDataEvents();
			Id = Id_DefaultValue = null;
			Labelrank = Labelrank_DefaultValue = null;
			MiddleX = MiddleX_DefaultValue = 0.5;
			MiddleY = MiddleY_DefaultValue = 0.5;
			Name = Name_DefaultValue = null;
			Path = Path_DefaultValue = "";
			Value = Value_DefaultValue = null;
			
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
		public MapSeriesDataEvents Events { get; set; }
		private MapSeriesDataEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the point. This can be used after render time to get a pointer to the point object through <code>chart.get()</code>.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// When data labels are laid out on a map, Highmaps runs a simplified algorithm to detect collision. When two labels collide, the one with the lowest rank is hidden. By default the rank is computed from the area.
		/// </summary>
		public double? Labelrank { get; set; }
		private double? Labelrank_DefaultValue { get; set; }
		 

		/// <summary>
		/// The relative mid point of an area, used to place the data label. Ranges from 0 to 1. When <code>mapData</code> is used, middleX can be defined there. 
		/// </summary>
		public double? MiddleX { get; set; }
		private double? MiddleX_DefaultValue { get; set; }
		 

		/// <summary>
		/// The relative mid point of an area, used to place the data label. Ranges from 0 to 1. When <code>mapData</code> is used, middleY can be defined there. 
		/// </summary>
		public double? MiddleY { get; set; }
		private double? MiddleY_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the point as shown in the legend, tooltip, dataLabel etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For map and mapline series types, the SVG path for the shape. For compatibily with old IE, not all SVG path definitions are supported, but M, L and C operators are safe.</p><p>To achieve a better separation between the structure and the data, it is recommended to use <code>mapData</code> to define that paths instead of defining them on the data points themselves.</p>
		/// </summary>
		public string Path { get; set; }
		private string Path_DefaultValue { get; set; }
		 

		/// <summary>
		/// The numeric value of the data point.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DataLabels != DataLabels_DefaultValue) h.Add("dataLabels",DataLabels);
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labelrank != Labelrank_DefaultValue) h.Add("labelrank",Labelrank);
			if (MiddleX != MiddleX_DefaultValue) h.Add("middleX",MiddleX);
			if (MiddleY != MiddleY_DefaultValue) h.Add("middleY",MiddleY);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Path != Path_DefaultValue) h.Add("path",Path);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			

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