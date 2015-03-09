using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace HighSoft.Web.Mvc
{
	public partial class YAxisPlotBands
	{
		public YAxisPlotBands()
		{
			BorderColor = BorderColor_DefaultValue = "null";
			BorderWidth = BorderWidth_DefaultValue = 0;
			Color = Color_DefaultValue = null;
			Events = Events_DefaultValue = null;
			From = From_DefaultValue = null;
			Id = Id_DefaultValue = null;
			InnerRadius = InnerRadius_DefaultValue = "null";
			Label = Label_DefaultValue = new YAxisPlotBandsLabel();
			OuterRadius = OuterRadius_DefaultValue = "100%";
			Thickness = Thickness_DefaultValue = "10";
			To = To_DefaultValue = null;
			ZIndex = ZIndex_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Border color for the plot band. Also requires <code>borderWidth</code> to be set.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Border width for the plot band.  Also requires <code>borderColor</code> to be set.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the plot band.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// An object defining mouse events for the plot band. Supported properties are <code>click</code>, <code>mouseover</code>, <code>mouseout</code>, <code>mousemove</code>.
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
		/// In a gauge chart, this option determines the inner radius of the plot band that stretches along the perimeter. It can be given as a percentage string, like <code>"100%"</code>, or as a pixel number, like <code>100</code>. By default, the inner radius is controlled by the <a href="#yAxis.plotBands.thickness">thickness</a> option.
		/// </summary>
		public string InnerRadius { get; set; }
		private string InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// Text labels for the plot bands
		/// </summary>
		public YAxisPlotBandsLabel Label { get; set; }
		private YAxisPlotBandsLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the outer radius of the plot band that stretches along the perimeter. It can be given as a percentage string, like <code>"100%"</code>, or as a pixel number, like <code>100</code>.
		/// </summary>
		public string OuterRadius { get; set; }
		private string OuterRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option sets the width of the plot band stretching along the perimeter. It can be given as a percentage string, like <code>"10%"</code>, or as a pixel number, like <code>10</code>. The default value 10 is the same as the default <a href="#yAxis.tickLength">tickLength</a>, thus making the plot band act as a background for the tick markers. 
		/// </summary>
		public string Thickness { get; set; }
		private string Thickness_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end position of the plot band in axis units.
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		 

		/// <summary>
		/// The z index of the plot band within the chart.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
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

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}