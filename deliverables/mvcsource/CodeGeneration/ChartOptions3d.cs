using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Highcharts
{
	public partial class ChartOptions3d  : BaseObject
	{
		public ChartOptions3d()
		{
			Alpha = Alpha_DefaultValue = 0;
			Beta = Beta_DefaultValue = 0;
			Depth = Depth_DefaultValue = 100;
			Enabled = Enabled_DefaultValue = false;
			Frame = Frame_DefaultValue = new ChartOptions3dFrame();
			ViewDistance = ViewDistance_DefaultValue = 100;
			
		}	
		

		/// <summary>
		/// One of the two rotation angles for the chart.
		/// </summary>
		public double? Alpha { get; set; }
		private double? Alpha_DefaultValue { get; set; }
		 

		/// <summary>
		/// One of the two rotation angles for the chart.
		/// </summary>
		public double? Beta { get; set; }
		private double? Beta_DefaultValue { get; set; }
		 

		/// <summary>
		/// The total depth of the chart.
		/// </summary>
		public double? Depth { get; set; }
		private double? Depth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Wether to render the chart using the 3D functionality.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Provides the option to draw a frame around the charts by defining a bottom, front and back panel. 
		/// </summary>
		public ChartOptions3dFrame Frame { get; set; }
		private ChartOptions3dFrame Frame_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the distance the viewer is standing in front of the chart, this setting is important to calculate the perspective effect in column and scatter charts.It is not used for 3D pie charts.
		/// </summary>
		public double? ViewDistance { get; set; }
		private double? ViewDistance_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Alpha != Alpha_DefaultValue) h.Add("alpha",Alpha);
			if (Beta != Beta_DefaultValue) h.Add("beta",Beta);
			if (Depth != Depth_DefaultValue) h.Add("depth",Depth);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Frame.IsDirty()) h.Add("frame",Frame.ToHashtable());
			if (ViewDistance != ViewDistance_DefaultValue) h.Add("viewDistance",ViewDistance);
			

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