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
	public partial class NavigatorSeries  : BaseObject
	{
		public NavigatorSeries()
		{
			Type = Type_DefaultValue = null;
			FillOpacity = FillOpacity_DefaultValue = null;
			LineWidth = LineWidth_DefaultValue = null;
			DataGrouping = DataGrouping_DefaultValue = new NavigatorSeriesDataGrouping();
			DataLabels = DataLabels_DefaultValue = new NavigatorSeriesDataLabels();
			Id = Id_DefaultValue = "highcharts-navigator-series";
			ClassName = ClassName_DefaultValue = "highcharts-navigator-series";
			LineColor = LineColor_DefaultValue = null;
			Marker = Marker_DefaultValue = new NavigatorSeriesMarker();
			PointRange = PointRange_DefaultValue = null;
			Threshold = Threshold_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The type of the navigator series. Defaults to <code>areaspline</code> ifdefined, otherwise <code>line</code>.</p>
		/// </summary>
		public string Type { get; set; }
		private string Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The fill opacity of the navigator series.</p>
		/// </summary>
		public double? FillOpacity { get; set; }
		private double? FillOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel line width of the navigator series.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Data grouping options for the navigator series.</p>
		/// </summary>
		public NavigatorSeriesDataGrouping DataGrouping { get; set; }
		private NavigatorSeriesDataGrouping DataGrouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Data label options for the navigator series. Data labels aredisabled by default on the navigator series.</p>
		/// </summary>
		public NavigatorSeriesDataLabels DataLabels { get; set; }
		private NavigatorSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Line color for the navigator series. Allows setting the colorwhile disallowing the default candlestick setting.</p>
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigatorSeriesMarker Marker { get; set; }
		private NavigatorSeriesMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? PointRange { get; set; }
		private double? PointRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The threshold option. Setting it to 0 will make the defaultnavigator area series draw its area from the 0 value and up.</p>
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (FillOpacity != FillOpacity_DefaultValue) h.Add("fillOpacity",FillOpacity);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (DataGrouping.IsDirty()) h.Add("dataGrouping",DataGrouping.ToHashtable());
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (PointRange != PointRange_DefaultValue) h.Add("pointRange",PointRange);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			

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