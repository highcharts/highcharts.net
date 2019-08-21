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
	public partial class YAxisPlotBands  : BaseObject
	{
		public YAxisPlotBands()
		{
			AcrossPanes = AcrossPanes_DefaultValue = true;
			BorderColor = BorderColor_DefaultValue = "";
			BorderWidth = BorderWidth_DefaultValue = 0;
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "";
			Events = Events_DefaultValue = null;
			From = From_DefaultValue = null;
			Id = Id_DefaultValue = "";
			InnerRadius = InnerRadius_DefaultValue = "";
			Label = Label_DefaultValue = new YAxisPlotBandsLabel();
			OuterRadius = OuterRadius_DefaultValue = "100%";
			Thickness = Thickness_DefaultValue = "10";
			To = To_DefaultValue = null;
			ZIndex = ZIndex_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Flag to decide if plotBand should be rendered across all panes.
		/// </summary>
		public bool? AcrossPanes { get; set; }
		private bool? AcrossPanes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Border color for the plot band. Also requires `borderWidth` to be set.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Border width for the plot band. Also requires `borderColor` to be set.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A custom class name, in addition to the default `highcharts-plot-band`,to apply to each individual band.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the plot band.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// An object defining mouse events for the plot band. Supported propertiesare `click`, `mouseover`, `mouseout`, `mousemove`.
		/// </summary>
		public Object Events { get; set; }
		private Object Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start position of the plot band in axis units.
		/// </summary>
		public double? From { get; set; }
		private double? From_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id used for identifying the plot band in Axis.removePlotBand.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the inner radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.By default, the inner radius is controlled by the [thickness](#yAxis.plotBands.thickness) option.
		/// </summary>
		public string InnerRadius { get; set; }
		private string InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// Text labels for the plot bands
		/// </summary>
		public YAxisPlotBandsLabel Label { get; set; }
		private YAxisPlotBandsLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the outer radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.
		/// </summary>
		public string OuterRadius { get; set; }
		private string OuterRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option sets the width of the plot bandstretching along the perimeter. It can be given as a percentagestring, like `"10%"`, or as a pixel number, like `10`. The defaultvalue 10 is the same as the default [tickLength](#yAxis.tickLength),thus making the plot band act as a background for the tick markers.
		/// </summary>
		public string Thickness { get; set; }
		private string Thickness_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end position of the plot band in axis units.
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		 

		/// <summary>
		/// The z index of the plot band within the chart, relative to otherelements. Using the same z index as another element may giveunpredictable results, as the last rendered element will be on top.Values from 0 to 20 make sense.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AcrossPanes != AcrossPanes_DefaultValue) h.Add("acrossPanes",AcrossPanes);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Events != Events_DefaultValue) h.Add("events",Events);
			if (From != From_DefaultValue) h.Add("from",From);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (OuterRadius != OuterRadius_DefaultValue) h.Add("outerRadius",OuterRadius);
			if (Thickness != Thickness_DefaultValue) h.Add("thickness",Thickness);
			if (To != To_DefaultValue) h.Add("to",To);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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