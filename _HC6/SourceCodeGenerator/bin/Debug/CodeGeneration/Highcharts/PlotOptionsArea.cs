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
	public partial class PlotOptionsArea  : BaseObject
	{
		public PlotOptionsArea()
		{
			SoftThreshold = SoftThreshold_DefaultValue = false;
			Threshold = Threshold_DefaultValue = 0;
			FillColor = FillColor_DefaultValue = null;
			FillOpacity = FillOpacity_DefaultValue = null;
			LineColor = LineColor_DefaultValue = "null";
			NegativeFillColor = NegativeFillColor_DefaultValue = null;
			TrackByArea = TrackByArea_DefaultValue = false;
			SoftThreshold = SoftThreshold_DefaultValue = false;
			Threshold = Threshold_DefaultValue = 0;
			FillColor = FillColor_DefaultValue = null;
			FillOpacity = FillOpacity_DefaultValue = null;
			LineColor = LineColor_DefaultValue = "null";
			NegativeFillColor = NegativeFillColor_DefaultValue = "";
			TrackByArea = TrackByArea_DefaultValue = false;
			
		}	
		

		/// <summary>
		/// When this is true, the series will not cause the Y axis to crossthe zero plane (or [threshold](#plotOptions.series.threshold) option)unless the data actually crosses the plane.For example, if `softThreshold` is `false`, a series of 0, 1, 2,3 will make the Y axis show negative values according to the `minPadding`option. If `softThreshold` is `true`, the Y axis starts at 0.
		/// </summary>
		public bool? SoftThreshold { get; set; }
		private bool? SoftThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Y axis value to serve as the base for the area, for distinguishingbetween values above and below a threshold. If `null`, the areabehaves like a line series with fill between the graph and the Yaxis minimum.
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fill color or gradient for the area. When `null`, the series' `color`is used with the series' `fillOpacity`.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fill opacity for the area. When you set an explicit `fillColor`,the `fillOpacity` is not applied. Instead, you should define theopacity in the `fillColor` with an rgba color definition. The `fillOpacity`setting, also the default setting, overrides the alpha componentof the `color` setting.
		/// </summary>
		public double? FillOpacity { get; set; }
		private double? FillOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// A separate color for the graph line. By default the line takes the`color` of the series, but the lineColor setting allows setting aseparate color for the line without altering the `fillColor`.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A separate color for the negative part of the area.
		/// </summary>
		public string NegativeFillColor { get; set; }
		private string NegativeFillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the whole area or just the line should respond to mouseovertooltips and other mouse or touch events.
		/// </summary>
		public bool? TrackByArea { get; set; }
		private bool? TrackByArea_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this is true, the series will not cause the Y axis to crossthe zero plane (or [threshold](#plotOptions.series.threshold) option)unless the data actually crosses the plane.For example, if `softThreshold` is `false`, a series of 0, 1, 2,3 will make the Y axis show negative values according to the `minPadding`option. If `softThreshold` is `true`, the Y axis starts at 0.
		/// </summary>
		public bool? SoftThreshold { get; set; }
		private bool? SoftThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Y axis value to serve as the base for the area, for distinguishingbetween values above and below a threshold. If `null`, the areabehaves like a line series with fill between the graph and the Yaxis minimum.
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fill color or gradient for the area. When `null`, the series' `color`is used with the series' `fillOpacity`.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fill opacity for the area. When you set an explicit `fillColor`,the `fillOpacity` is not applied. Instead, you should define theopacity in the `fillColor` with an rgba color definition. The `fillOpacity`setting, also the default setting, overrides the alpha componentof the `color` setting.
		/// </summary>
		public double? FillOpacity { get; set; }
		private double? FillOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// A separate color for the graph line. By default the line takes the`color` of the series, but the lineColor setting allows setting aseparate color for the line without altering the `fillColor`.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A separate color for the negative part of the area.
		/// </summary>
		public string NegativeFillColor { get; set; }
		private string NegativeFillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the whole area or just the line should respond to mouseovertooltips and other mouse or touch events.
		/// </summary>
		public bool? TrackByArea { get; set; }
		private bool? TrackByArea_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (FillOpacity != FillOpacity_DefaultValue) h.Add("fillOpacity",FillOpacity);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (NegativeFillColor != NegativeFillColor_DefaultValue) h.Add("negativeFillColor",NegativeFillColor);
			if (TrackByArea != TrackByArea_DefaultValue) h.Add("trackByArea",TrackByArea);
			if (SoftThreshold != SoftThreshold_DefaultValue) h.Add("softThreshold",SoftThreshold);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (FillOpacity != FillOpacity_DefaultValue) h.Add("fillOpacity",FillOpacity);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (NegativeFillColor != NegativeFillColor_DefaultValue) h.Add("negativeFillColor",NegativeFillColor);
			if (TrackByArea != TrackByArea_DefaultValue) h.Add("trackByArea",TrackByArea);
			

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