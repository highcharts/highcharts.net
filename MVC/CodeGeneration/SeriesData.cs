using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace HighSoft.Web.Mvc
{
	public partial class SeriesData
	{
        public SeriesData()
        {
            Color = Color_DefaultValue = "undefined";
            DataLabels = DataLabels_DefaultValue = null;
            Drilldown = Drilldown_DefaultValue = "";
            Events = Events_DefaultValue = new SeriesDataEvents();
            Id = Id_DefaultValue = null;
            IsIntermediateSum = IsIntermediateSum_DefaultValue = false;
            IsSum = IsSum_DefaultValue = false;
            LegendIndex = LegendIndex_DefaultValue = null;
            Marker = Marker_DefaultValue = new SeriesDataMarker();
            Name = Name_DefaultValue = null;
            Sliced = Sliced_DefaultValue = false;
            X = X_DefaultValue = null;
            Y = Y_DefaultValue = null;
        }		

		/// <summary>
		/// Individual color for the point. By default the color is pulled from the global <code>colors</code> array.
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
		public SeriesDataEvents Events { get; set; }
		private SeriesDataEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the point. This can be used after render time to get a pointer to the point object through <code>chart.get()</code>.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// Waterfall series only. When this property is true, the points acts as a summary column for the values added or substracted since the last intermediate sum, or since the start of the series. The <code>y</code> value is ignored.
		/// </summary>
		public bool? IsIntermediateSum { get; set; }
		private bool? IsIntermediateSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// Waterfall series only. When this property is true, the point display the total sum across the entire series. The <code>y</code> value is ignored.
		/// </summary>
		public bool? IsSum { get; set; }
		private bool? IsSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pies only. The sequential index of the pie slice in the legend..
		/// </summary>
		public double? LegendIndex { get; set; }
		private double? LegendIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public SeriesDataMarker Marker { get; set; }
		private SeriesDataMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the point as shown in the legend, tooltip, dataLabel etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pie series only. Whether to display a slice offset from the center.
		/// </summary>
		public bool? Sliced { get; set; }
		private bool? Sliced_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x value of the point.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y value of the point.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DataLabels != DataLabels_DefaultValue) h.Add("dataLabels",DataLabels);
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (IsIntermediateSum != IsIntermediateSum_DefaultValue) h.Add("isIntermediateSum",IsIntermediateSum);
			if (IsSum != IsSum_DefaultValue) h.Add("isSum",IsSum);
			if (LegendIndex != LegendIndex_DefaultValue) h.Add("legendIndex",LegendIndex);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Sliced != Sliced_DefaultValue) h.Add("sliced",Sliced);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}