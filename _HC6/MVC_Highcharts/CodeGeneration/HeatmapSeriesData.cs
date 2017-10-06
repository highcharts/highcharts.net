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
	public partial class HeatmapSeriesData  : BaseObject
	{
		public HeatmapSeriesData()
		{
			Color = Color_DefaultValue = "undefined";
			Value = Value_DefaultValue = null;
			PointPadding = PointPadding_DefaultValue = null;
			Drilldown = Drilldown_DefaultValue = null;
			ClassName = ClassName_DefaultValue = null;
			ColorIndex = ColorIndex_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = new HeatmapSeriesDataLabels();
			Description = Description_DefaultValue = "undefined";
			Id = Id_DefaultValue = "null";
			Labelrank = Labelrank_DefaultValue = null;
			Name = Name_DefaultValue = null;
			Selected = Selected_DefaultValue = false;
			Events = Events_DefaultValue = new HeatmapSeriesDataEvents();
			
		}	
		

		/// <summary>
		/// <p>The color of the point. In heat maps the point color is rarely setexplicitly, as we use the color to denote the <code>value</code>. Options forthis are set in the <a href="#colorAxis">colorAxis</a> configuration.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The value of the point, resulting in a color controled by optionsas set in the <a href="#colorAxis">colorAxis</a> configuration.</p>
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Point padding for a single point.</p>
		/// </summary>
		public double? PointPadding { get; set; }
		private double? PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The <code>id</code> of a series in the <a href="#drilldown.series">drilldown.series</a>array to use for a drilldown for this point.</p>
		/// </summary>
		public string Drilldown { get; set; }
		private string Drilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An additional, individual class name for the data point&#39;s graphicrepresentation.</p>
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Styled mode only. A specific color index to use for the point, so itsgraphic representations are given the class name <code>highcharts-color-{n}</code>.</p>
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Individual data label for each point. The options are the same asthe ones for <a href="#plotOptions.series.dataLabels">plotOptions.series.dataLabels</a></p>
		/// </summary>
		public HeatmapSeriesDataLabels DataLabels { get; set; }
		private HeatmapSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

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
		/// <p>Individual point events</p>
		/// </summary>
		public HeatmapSeriesDataEvents Events { get; set; }
		private HeatmapSeriesDataEvents Events_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labelrank != Labelrank_DefaultValue) h.Add("labelrank",Labelrank);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
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