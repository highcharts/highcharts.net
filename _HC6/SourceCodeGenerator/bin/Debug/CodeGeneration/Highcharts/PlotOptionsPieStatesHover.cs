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
	public partial class PlotOptionsPieStatesHover  : BaseObject
	{
		public PlotOptionsPieStatesHover()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Brightness = Brightness_DefaultValue = null;
			Enabled = Enabled_DefaultValue = true;
			Halo = Halo_DefaultValue = new PlotOptionsPieStatesHoverHalo();
			
		}	
		

		/// <summary>
		/// Animation setting for hovering the graph in line-type series.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// How much to brighten the point on interaction. Requires the maincolor to be defined in hex or rgb(a) format.In styled mode, the hover brightness is by default replacedby a fill-opacity given in the `.highcharts-point-hover` class.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable separate styles for the hovered series to visualize thatthe user hovers either the series itself or the legend. .
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the halo appearing around the hovered point in line-type series as well as outside the hovered slice in pie charts.By default the halo is filled by the current point or seriescolor with an opacity of 0.25\. The halo can be disabled bysetting the `halo` option to `false`.In styled mode, the halo is styled with the `.highcharts-halo`class, with colors inherited from `.highcharts-color-{n}`.
		/// </summary>
		public PlotOptionsPieStatesHoverHalo Halo { get; set; }
		private PlotOptionsPieStatesHoverHalo Halo_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Halo.IsDirty()) h.Add("halo",Halo.ToHashtable());
			

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