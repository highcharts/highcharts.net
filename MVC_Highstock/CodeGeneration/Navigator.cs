using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highstock.Web.Mvc
{
	public partial class Navigator  : BaseObject
	{
		public Navigator()
		{
			AdaptToUpdatedData = AdaptToUpdatedData_DefaultValue = true;
			Enabled = Enabled_DefaultValue = true;
			Handles = Handles_DefaultValue = null;
			Height = Height_DefaultValue = 40;
			Margin = Margin_DefaultValue = 25;
			MaskFill = MaskFill_DefaultValue = "rgba(128,179,236,0.3)";
			MaskInside = MaskInside_DefaultValue = true;
			OutlineColor = OutlineColor_DefaultValue = "#b2b1b6";
			OutlineWidth = OutlineWidth_DefaultValue = 2;
			Series = Series_DefaultValue = null;
			XAxis = XAxis_DefaultValue = null;
			YAxis = YAxis_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Whether the navigator and scrollbar should adapt to updated data in the base X axis. This should be false when loading data asynchronously, to prevent circular loading.
		/// </summary>
		public bool? AdaptToUpdatedData { get; set; }
		private bool? AdaptToUpdatedData_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the navigator.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the handles for dragging the zoomed area. Available options are <code>backgroundColor</code> (defaults to <code>#ebe7e8</code>) and <code>borderColor</code> (defaults to <code>#b2b1b6</code>).
		/// </summary>
		public Object Handles { get; set; }
		private Object Handles_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the navigator.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance from the nearest element, the X axis or X axis labels.
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the mask covering the areas of the navigator series that are currently not visible in the main series. The default color is bluish with an opacity of 0.3 to see the series below.
		/// </summary>
		public string MaskFill { get; set; }
		private string MaskFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the mask should be inside the range marking the zoomed range, or outside. In Highstock 1.x it was always <code>false</code>.
		/// </summary>
		public bool? MaskInside { get; set; }
		private bool? MaskInside_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the line marking the currently zoomed area in the navigator.
		/// </summary>
		public string OutlineColor { get; set; }
		private string OutlineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the line marking the currently zoomed area in the navigator.
		/// </summary>
		public double? OutlineWidth { get; set; }
		private double? OutlineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the navigator series. Available options are the same as any series, documented at <a class="internal" href="#plotOptions.series">plotOptions</a> and <a class="internal" href="#series">series</a>.</p><p>Unless data is explicitly defined on navigator.series, the data is borrowed from the first series in the chart.</p><p>Default series options for the navigator series are:</p><pre>series: {type: 'areaspline',color: '#4572A7',fillOpacity: 0.05,dataGrouping: {smoothed: true},lineWidth: 1,marker: {enabled: false}}</pre>
		/// </summary>
		public Object Series { get; set; }
		private Object Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the navigator X axis. Available options are the same as any X axis, documented at <a class="internal" href="#xAxis">xAxis</a>. Default series options for the navigator xAxis are:<pre>xAxis: {    tickWidth: 0,    lineWidth: 0,    gridLineWidth: 1,    tickPixelInterval: 200,    labels: {        align: 'left',        style: {            color: '#888'        },        x: 3,        y: -4    }}</pre>
		/// </summary>
		public Object XAxis { get; set; }
		private Object XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the navigator Y axis. Available options are the same as any y axis, documented at <a class="internal" href="#yAxis">yAxis</a>. Default series options for the navigator yAxis are:<pre>yAxis: {gridLineWidth: 0,startOnTick: false,endOnTick: false,minPadding: 0.1,maxPadding: 0.1,labels: {enabled: false},title: {text: null},tickWidth: 0}</pre>
		/// </summary>
		public Object YAxis { get; set; }
		private Object YAxis_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AdaptToUpdatedData != AdaptToUpdatedData_DefaultValue) h.Add("adaptToUpdatedData",AdaptToUpdatedData);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Handles != Handles_DefaultValue) h.Add("handles",Handles);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (MaskFill != MaskFill_DefaultValue) h.Add("maskFill",MaskFill);
			if (MaskInside != MaskInside_DefaultValue) h.Add("maskInside",MaskInside);
			if (OutlineColor != OutlineColor_DefaultValue) h.Add("outlineColor",OutlineColor);
			if (OutlineWidth != OutlineWidth_DefaultValue) h.Add("outlineWidth",OutlineWidth);
			if (Series != Series_DefaultValue) h.Add("series",Series);
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			

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