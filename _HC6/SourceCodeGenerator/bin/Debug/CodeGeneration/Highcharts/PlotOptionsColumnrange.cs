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
	public partial class PlotOptionsColumnrange  : BaseObject
	{
		public PlotOptionsColumnrange()
		{
			PointRange = PointRange_DefaultValue = null;
			Marker = Marker_DefaultValue = null;
			States = States_DefaultValue = null;
			PointRange = PointRange_DefaultValue = "";
			Marker = Marker_DefaultValue = "";
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			DataLabels = DataLabels_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsColumnrangePointRange PointRange { get; set; }
		private PlotOptionsColumnrangePointRange PointRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsColumnrangeMarker Marker { get; set; }
		private PlotOptionsColumnrangeMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsColumnrangeStates States { get; set; }
		private PlotOptionsColumnrangeStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsColumnrangePointRange PointRange { get; set; }
		private PlotOptionsColumnrangePointRange PointRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsColumnrangeMarker Marker { get; set; }
		private PlotOptionsColumnrangeMarker Marker_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsColumnrangeStates States { get; set; }
		private PlotOptionsColumnrangeStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsColumnrangeHover Hover { get; set; }
		private PlotOptionsColumnrangeHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// Extended data labels for range series types. Range series data labelshave no `x` and `y` options. Instead, they have `xLow`, `xHigh`,`yLow` and `yHigh` options to allow the higher and lower data labelsets individually.
		/// </summary>
		public PlotOptionsColumnrangeDataLabels DataLabels { get; set; }
		private PlotOptionsColumnrangeDataLabels DataLabels_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (PointRange != PointRange_DefaultValue) h.Add("pointRange",PointRange);
			if (Marker != Marker_DefaultValue) h.Add("marker",Marker);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (PointRange != PointRange_DefaultValue) h.Add("pointRange",PointRange);
			if (Marker != Marker_DefaultValue) h.Add("marker",Marker);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover != Hover_DefaultValue) h.Add("hover",Hover);
			if (DataLabels != DataLabels_DefaultValue) h.Add("dataLabels",DataLabels);
			

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