using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class ScatterSeriesDataMarkerStatesSelect  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ScatterSeriesDataMarkerStatesSelect()
		{
			Enabled = Enabled_DefaultValue = new Hashtable();
			FillColor = FillColor_DefaultValue = "";
			LineColor = LineColor_DefaultValue = "";
			LineWidth = LineWidth_DefaultValue = new Hashtable();
			Radius = Radius_DefaultValue = new Hashtable();
			
		}	
		

		/// <summary>
		/// Enable or disable visible feedback for selection.
		/// </summary>
		public Hashtable Enabled { get; set; }
		private Hashtable Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the point marker.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the point marker's outline. When`undefined`, the series' or point's color is used.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the point marker's outline.
		/// </summary>
		public Hashtable LineWidth { get; set; }
		private Hashtable LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius of the point marker. In hover state, itdefaults to the normal state's radius + 2.
		/// </summary>
		public Hashtable Radius { get; set; }
		private Hashtable Radius_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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