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
	public partial class Pane  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Pane()
		{
			Background = Background_DefaultValue = new List<PaneBackground>();
			Center = Center_DefaultValue = new string[] { "50%", "50%" };
			EndAngle = EndAngle_DefaultValue = null;
			InnerSize = InnerSize_DefaultValue = "0%";
			InnerSizeNumber = InnerSizeNumber_DefaultValue = null;
			Size = Size_DefaultValue = "85%";
			SizeNumber = SizeNumber_DefaultValue = null;
			StartAngle = StartAngle_DefaultValue = 0;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// An array of background items for the pane.
		/// </summary>
		public List<PaneBackground> Background { get; set; }
		private List<PaneBackground> Background_DefaultValue { get; set; }
		 

		/// <summary>
		/// The center of a polar chart or angular gauge, given as an arrayof [x, y] positions. Positions can be given as integers thattransform to pixels, or as percentages of the plot area size.
		/// </summary>
		public string[] Center { get; set; }
		private string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end angle of the polar X axis or gauge value axis, given indegrees where 0 is north. Defaults to [startAngle](#pane.startAngle)+ 360.
		/// </summary>
		public double? EndAngle { get; set; }
		private double? EndAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner size of the pane, either as a number defining pixels, or apercentage defining a percentage of the pane's size.
		/// </summary>
		public string InnerSize { get; set; }
		private string InnerSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner size of the pane, either as a number defining pixels, or apercentage defining a percentage of the pane's size.
		/// </summary>
		public double? InnerSizeNumber { get; set; }
		private double? InnerSizeNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// The size of the pane, either as a number defining pixels, or apercentage defining a percentage of the available plot area (thesmallest of the plot height or plot width).
		/// </summary>
		public string Size { get; set; }
		private string Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// The size of the pane, either as a number defining pixels, or apercentage defining a percentage of the available plot area (thesmallest of the plot height or plot width).
		/// </summary>
		public double? SizeNumber { get; set; }
		private double? SizeNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start angle of the polar X axis or gauge axis, given in degreeswhere 0 is north. Defaults to 0.
		/// </summary>
		public double? StartAngle { get; set; }
		private double? StartAngle_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Background != Background_DefaultValue) h.Add("background", HashifyList(highcharts,Background));
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (EndAngle != EndAngle_DefaultValue) h.Add("endAngle",EndAngle);
			if (InnerSize != InnerSize_DefaultValue) h.Add("innerSize",InnerSize);
			if (InnerSizeNumber != InnerSizeNumber_DefaultValue) h.Add("innerSize",InnerSizeNumber);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (SizeNumber != SizeNumber_DefaultValue) h.Add("size",SizeNumber);
			if (StartAngle != StartAngle_DefaultValue) h.Add("startAngle",StartAngle);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}