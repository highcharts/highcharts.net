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
	public partial class PlotOptionsSolidgauge  : BaseObject
	{
		public PlotOptionsSolidgauge()
		{
			ColorByPoint = ColorByPoint_DefaultValue = True;
			Linecap = Linecap_DefaultValue = "round";
			Rounded = Rounded_DefaultValue = false;
			Threshold = Threshold_DefaultValue = null;
			ColorByPoint = ColorByPoint_DefaultValue = True;
			Linecap = Linecap_DefaultValue = "round";
			Rounded = Rounded_DefaultValue = false;
			Threshold = Threshold_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Whether to give each point an individual color.
		/// </summary>
		public PlotOptionsSolidgaugeColorByPoint ColorByPoint { get; set; }
		private PlotOptionsSolidgaugeColorByPoint ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the strokes of the solid gauge should be `round` or `square`.
		/// </summary>
		public string Linecap { get; set; }
		private string Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Wether to draw rounded edges on the gauge.
		/// </summary>
		public bool? Rounded { get; set; }
		private bool? Rounded_DefaultValue { get; set; }
		 

		/// <summary>
		/// The threshold or base level for the gauge.
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to give each point an individual color.
		/// </summary>
		public PlotOptionsSolidgaugeColorByPoint ColorByPoint { get; set; }
		private PlotOptionsSolidgaugeColorByPoint ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the strokes of the solid gauge should be `round` or `square`.
		/// </summary>
		public string Linecap { get; set; }
		private string Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Wether to draw rounded edges on the gauge.
		/// </summary>
		public bool? Rounded { get; set; }
		private bool? Rounded_DefaultValue { get; set; }
		 

		/// <summary>
		/// The threshold or base level for the gauge.
		/// </summary>
		public double? Threshold { get; set; }
		private double? Threshold_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (Linecap != Linecap_DefaultValue) h.Add("linecap",Linecap);
			if (Rounded != Rounded_DefaultValue) h.Add("rounded",Rounded);
			if (Threshold != Threshold_DefaultValue) h.Add("threshold",Threshold);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (Linecap != Linecap_DefaultValue) h.Add("linecap",Linecap);
			if (Rounded != Rounded_DefaultValue) h.Add("rounded",Rounded);
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