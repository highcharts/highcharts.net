using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class TreemapSeriesData
	{
		public TreemapSeriesData()
		{
			Color = Color_DefaultValue = null;
			ColorValue = ColorValue_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = null;
			Drilldown = Drilldown_DefaultValue = "";
			Events = Events_DefaultValue = new TreemapSeriesDataEvents();
			Id = Id_DefaultValue = null;
			Name = Name_DefaultValue = null;
			Parent = Parent_DefaultValue = "undefined";
			Selected = Selected_DefaultValue = false;
			Value = Value_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The color of the point. In heat maps the point color is rarely set explicitly, as we use the color to denote the <code>value</code>. Options for this are set in the <a href="#colorAxis">colorAxis</a> configuration.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Serves a purpose only if a colorAxis object is defined in the chart options. This value will decide which color the point gets from the scale of the colorAxis.
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		 

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
		public TreemapSeriesDataEvents Events { get; set; }
		private TreemapSeriesDataEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the point. This can be used after render time to get a pointer to the point object through <code>chart.get()</code>.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The name of the point as shown in the legend, tooltip, dataLabel etc.</p><p>If the <a href="#xAxis.type">xAxis.type</a> is set to <code>category</code>, and no <a href="#xAxis.categories">categories</a> option exists, the category will be pulled from the <code>point.name</code> of the last series defined. For multiple series, best practice however is to define <code>xAxis.categories</code>.</p>
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// Only for treemap. Use this option to build a tree structure. The value should be the id of the point which is the parent. If no points has a matching id, or this option is undefined, then the parent will be set to the root.
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the data point is selected initially.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value of the point, resulting in a relative area of the point in the treemap.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			if (DataLabels != DataLabels_DefaultValue) h.Add("dataLabels",DataLabels);
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			

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