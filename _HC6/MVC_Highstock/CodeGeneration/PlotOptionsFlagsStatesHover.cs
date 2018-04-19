using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsFlagsStatesHover  : BaseObject
	{
		public PlotOptionsFlagsStatesHover()
		{
			LineColor = LineColor_DefaultValue = "#000000";
			FillColor = FillColor_DefaultValue = null;
			Enabled = Enabled_DefaultValue = true;
			Brightness = Brightness_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = "";
			Color = Color_DefaultValue = "undefined";
			
		}	
		

		/// <summary>
		/// The color of the line/border of the flag.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill or background color of the flag.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable separate styles for the hovered series to visualize thatthe user hovers either the series itself or the legend. .
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// How much to brighten the point on interaction. Requires the maincolor to be defined in hex or rgb(a) format.In styled mode, the hover brightening is by default replacedwith a fill-opacity set in the `.highcharts-point:hover` rule.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// A specific border color for the hovered point. Defaults toinherit the normal state border color.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A specific color for the hovered point.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			

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