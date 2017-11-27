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
	public partial class PlotOptionsStreamgraph  : BaseObject
	{
		public PlotOptionsStreamgraph()
		{
			FillOpacity = FillOpacity_DefaultValue = 1;
			LineWidth = LineWidth_DefaultValue = 0;
			Marker = Marker_DefaultValue = null;
			Stacking = Stacking_DefaultValue = stream;
			FillOpacity = FillOpacity_DefaultValue = 1;
			LineWidth = LineWidth_DefaultValue = 0;
			Marker = Marker_DefaultValue = "";
			Enabled = Enabled_DefaultValue = False;
			Stacking = Stacking_DefaultValue = stream;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsStreamgraphFillOpacity FillOpacity { get; set; }
		private PlotOptionsStreamgraphFillOpacity FillOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsStreamgraphLineWidth LineWidth { get; set; }
		private PlotOptionsStreamgraphLineWidth LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsStreamgraphMarker Marker { get; set; }
		private PlotOptionsStreamgraphMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsStreamgraphStacking Stacking { get; set; }
		private PlotOptionsStreamgraphStacking Stacking_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsStreamgraphFillOpacity FillOpacity { get; set; }
		private PlotOptionsStreamgraphFillOpacity FillOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsStreamgraphLineWidth LineWidth { get; set; }
		private PlotOptionsStreamgraphLineWidth LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsStreamgraphMarker Marker { get; set; }
		private PlotOptionsStreamgraphMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsStreamgraphEnabled Enabled { get; set; }
		private PlotOptionsStreamgraphEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsStreamgraphStacking Stacking { get; set; }
		private PlotOptionsStreamgraphStacking Stacking_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (FillOpacity != FillOpacity_DefaultValue) h.Add("fillOpacity",FillOpacity);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (Stacking != Stacking_DefaultValue) h.Add("stacking",Stacking);
			if (FillOpacity != FillOpacity_DefaultValue) h.Add("fillOpacity",FillOpacity);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Marker.IsDirty()) h.Add("marker",Marker.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Stacking != Stacking_DefaultValue) h.Add("stacking",Stacking);
			

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