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
			Name = Name_DefaultValue = "undefined";
			Weight = Weight_DefaultValue = null;
			Parent = Parent_DefaultValue = "undefined";
			ColorValue = ColorValue_DefaultValue = null;
			Color = Color_DefaultValue = "undefined";
			PointPadding = PointPadding_DefaultValue = null;
			Drilldown = Drilldown_DefaultValue = null;
			ClassName = ClassName_DefaultValue = null;
			ColorIndex = ColorIndex_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = new SunburstSeriesDataLabels();
			Description = Description_DefaultValue = "undefined";
			Id = Id_DefaultValue = "null";
			Labelrank = Labelrank_DefaultValue = null;
			Selected = Selected_DefaultValue = false;
			Events = Events_DefaultValue = new SunburstSeriesDataEvents();
			
		}	
		

		/// <summary>
		/// <p>The value of the point, resulting in a relative area of the pointin the sunburst.</p>
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The name decides the text for a word.</p>
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The weighting of a word. The weight decides the relative size of a wordcompared to the rest of the collection.</p>
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Only for treemap. Use this option to build a tree structure. Thevalue should be the id of the point which is the parent. If no pointshas a matching id, or this option is undefined, then the parent willbe set to the root.</p>
		/// </summary>
		public string Parent { get; set; }
		private string Parent_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Serves a purpose only if a <code>colorAxis</code> object is defined in the chartoptions. This value will decide which color the point gets from thescale of the colorAxis.</p>
		/// </summary>
		public double? ColorValue { get; set; }
		private double? ColorValue_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the point. In heat maps the point color is rarely setexplicitly, as we use the color to denote the <code>value</code>. Options forthis are set in the <a href="#colorAxis">colorAxis</a> configuration.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

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
		public SunburstSeriesDataLabels DataLabels { get; set; }
		private SunburstSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

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
		/// <p>Whether the data point is selected initially.</p>
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Individual point events</p>
		/// </summary>
		public SunburstSeriesDataEvents Events { get; set; }
		private SunburstSeriesDataEvents Events_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Value != Value_DefaultValue) h.Add("value",Value);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (Parent != Parent_DefaultValue) h.Add("parent",Parent);
			if (ColorValue != ColorValue_DefaultValue) h.Add("colorValue",ColorValue);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (Drilldown != Drilldown_DefaultValue) h.Add("drilldown",Drilldown);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labelrank != Labelrank_DefaultValue) h.Add("labelrank",Labelrank);
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