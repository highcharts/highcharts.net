using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class ChartOptions3d  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartOptions3d()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// One of the two rotation angles for the chart.
		/// </summary>
		public double? Alpha { get; set; }
		 

		/// <summary>
		/// Set it to `"auto"` to automatically move the labels to thebest edge.
		/// </summary>
		public string AxisLabelPosition { get; set; }
		 

		/// <summary>
		/// One of the two rotation angles for the chart.
		/// </summary>
		public double? Beta { get; set; }
		 

		/// <summary>
		/// The total depth of the chart.
		/// </summary>
		public double? Depth { get; set; }
		 

		/// <summary>
		/// Whether to render the chart using the 3D functionality.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Whether the 3d box should automatically adjust to the chartplot area.
		/// </summary>
		public bool? FitToPlot { get; set; }
		 

		/// <summary>
		/// Provides the option to draw a frame around the charts bydefining a bottom, front and back panel.
		/// </summary>
		public ChartOptions3dFrame Frame { get; set; }
		 

		/// <summary>
		/// Defines the distance the viewer is standing in front of thechart, this setting is important to calculate the perspectiveeffect in column and scatter charts. It is not used for 3Dpie charts.
		/// </summary>
		public double? ViewDistance { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Alpha != null) h.Add("alpha",Alpha);
			if (AxisLabelPosition != null) h.Add("axisLabelPosition",AxisLabelPosition);
			if (Beta != null) h.Add("beta",Beta);
			if (Depth != null) h.Add("depth",Depth);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (FitToPlot != null) h.Add("fitToPlot",FitToPlot);
			if (Frame != null) h.Add("frame",Frame.ToHashtable(highcharts));
			if (ViewDistance != null) h.Add("viewDistance",ViewDistance);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}