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
	public partial class PlotOptionsPolygon  : BaseObject
	{
		public PlotOptionsPolygon()
		{
			Marker = Marker_DefaultValue = null;
			StickyTracking = StickyTracking_DefaultValue = False;
			TrackByArea = TrackByArea_DefaultValue = True;
			Marker = Marker_DefaultValue = "";
			Enabled = Enabled_DefaultValue = False;
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			Enabled = Enabled_DefaultValue = False;
			StickyTracking = StickyTracking_DefaultValue = False;
			FollowPointer = FollowPointer_DefaultValue = True;
			PointFormat = PointFormat_DefaultValue = "";
			TrackByArea = TrackByArea_DefaultValue = True;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPolygonMarker Marker { get; set; }
		private PlotOptionsPolygonMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPolygonStickyTracking StickyTracking { get; set; }
		private PlotOptionsPolygonStickyTracking StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPolygonTrackByArea TrackByArea { get; set; }
		private PlotOptionsPolygonTrackByArea TrackByArea_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPolygonMarker Marker { get; set; }
		private PlotOptionsPolygonMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPolygonEnabled Enabled { get; set; }
		private PlotOptionsPolygonEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPolygonStates States { get; set; }
		private PlotOptionsPolygonStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPolygonHover Hover { get; set; }
		private PlotOptionsPolygonHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPolygonEnabled Enabled { get; set; }
		private PlotOptionsPolygonEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPolygonStickyTracking StickyTracking { get; set; }
		private PlotOptionsPolygonStickyTracking StickyTracking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPolygonFollowPointer FollowPointer { get; set; }
		private PlotOptionsPolygonFollowPointer FollowPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPolygonPointFormat PointFormat { get; set; }
		private PlotOptionsPolygonPointFormat PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPolygonTrackByArea TrackByArea { get; set; }
		private PlotOptionsPolygonTrackByArea TrackByArea_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (TrackByArea != TrackByArea_DefaultValue) h.Add("trackByArea",TrackByArea);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (StickyTracking != StickyTracking_DefaultValue) h.Add("stickyTracking",StickyTracking);
			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
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