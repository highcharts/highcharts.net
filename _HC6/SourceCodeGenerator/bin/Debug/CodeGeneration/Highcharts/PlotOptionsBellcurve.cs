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
	public partial class PlotOptionsBellcurve  : BaseObject
	{
		public PlotOptionsBellcurve()
		{
			Intervals = Intervals_DefaultValue = 3;
			PointsInInterval = PointsInInterval_DefaultValue = 3;
			Marker = Marker_DefaultValue = null;
			Intervals = Intervals_DefaultValue = 3;
			PointsInInterval = PointsInInterval_DefaultValue = 3;
			Marker = Marker_DefaultValue = "";
			Enabled = Enabled_DefaultValue = False;
			
		}	
		

		/// <summary>
		/// This option allows to define the length of the bell curve. A unit of thelength of the bell curve is standard deviation.
		/// </summary>
		public PlotOptionsBellcurveIntervals Intervals { get; set; }
		private PlotOptionsBellcurveIntervals Intervals_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines how many points should be plotted within 1 interval. See `plotOptions.bellcurve.intervals`.
		/// </summary>
		public PlotOptionsBellcurvePointsInInterval PointsInInterval { get; set; }
		private PlotOptionsBellcurvePointsInInterval PointsInInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBellcurveMarker Marker { get; set; }
		private PlotOptionsBellcurveMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option allows to define the length of the bell curve. A unit of thelength of the bell curve is standard deviation.
		/// </summary>
		public PlotOptionsBellcurveIntervals Intervals { get; set; }
		private PlotOptionsBellcurveIntervals Intervals_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines how many points should be plotted within 1 interval. See `plotOptions.bellcurve.intervals`.
		/// </summary>
		public PlotOptionsBellcurvePointsInInterval PointsInInterval { get; set; }
		private PlotOptionsBellcurvePointsInInterval PointsInInterval_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBellcurveMarker Marker { get; set; }
		private PlotOptionsBellcurveMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBellcurveEnabled Enabled { get; set; }
		private PlotOptionsBellcurveEnabled Enabled_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Intervals != Intervals_DefaultValue) h.Add("intervals",Intervals);
			if (PointsInInterval != PointsInInterval_DefaultValue) h.Add("pointsInInterval",PointsInInterval);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (Intervals != Intervals_DefaultValue) h.Add("intervals",Intervals);
			if (PointsInInterval != PointsInInterval_DefaultValue) h.Add("pointsInInterval",PointsInInterval);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			

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