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
	public partial class PlotOptionsFunnel  : BaseObject
	{
		public PlotOptionsFunnel()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Center = Center_DefaultValue = new string[] { "50%", "50%" };
			Width = Width_DefaultValue = 90%;
			NeckWidth = NeckWidth_DefaultValue = 30%;
			Height = Height_DefaultValue = 100%;
			NeckHeight = NeckHeight_DefaultValue = 25%;
			Reversed = Reversed_DefaultValue = false;
			States = States_DefaultValue = null;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Center = Center_DefaultValue = new string[] { "50%", "50%" };
			Width = Width_DefaultValue = 90%;
			NeckWidth = NeckWidth_DefaultValue = 30%;
			Height = Height_DefaultValue = 100%;
			NeckHeight = NeckHeight_DefaultValue = 25%;
			Reversed = Reversed_DefaultValue = false;
			DataLabels = DataLabels_DefaultValue = "";
			ConnectorWidth = ConnectorWidth_DefaultValue = 1;
			States = States_DefaultValue = "";
			Select = Select_DefaultValue = "";
			Color = Color_DefaultValue = #cccccc;
			BorderColor = BorderColor_DefaultValue = #000000;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			
		}	
		

		/// <summary>
		/// Initial animation is by default disabled for the funnel chart.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The center of the series. By default, it is centered in the middleof the plot area, so it fills the plot area height.
		/// </summary>
		public string[] Center { get; set; }
		private string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the funnel compared to the width of the plot area,or the pixel width if it is a number.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the neck, the lower part of the funnel. A number definespixel width, a percentage string defines a percentage of the plotarea width.
		/// </summary>
		public double? NeckWidth { get; set; }
		private double? NeckWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the funnel or pyramid. If it is a number it definesthe pixel height, if it is a percentage string it is the percentageof the plot area height.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the neck, the lower part of the funnel. A number definespixel width, a percentage string defines a percentage of the plotarea height.
		/// </summary>
		public double? NeckHeight { get; set; }
		private double? NeckHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// A reversed funnel has the widest area down. A reversed funnel withno neck width and neck height is a pyramid.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the series states.
		/// </summary>
		public PlotOptionsFunnelStates States { get; set; }
		private PlotOptionsFunnelStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Initial animation is by default disabled for the funnel chart.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The center of the series. By default, it is centered in the middleof the plot area, so it fills the plot area height.
		/// </summary>
		public string[] Center { get; set; }
		private string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the funnel compared to the width of the plot area,or the pixel width if it is a number.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the neck, the lower part of the funnel. A number definespixel width, a percentage string defines a percentage of the plotarea width.
		/// </summary>
		public double? NeckWidth { get; set; }
		private double? NeckWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the funnel or pyramid. If it is a number it definesthe pixel height, if it is a percentage string it is the percentageof the plot area height.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the neck, the lower part of the funnel. A number definespixel width, a percentage string defines a percentage of the plotarea height.
		/// </summary>
		public double? NeckHeight { get; set; }
		private double? NeckHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// A reversed funnel has the widest area down. A reversed funnel withno neck width and neck height is a pyramid.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsFunnelDataLabels DataLabels { get; set; }
		private PlotOptionsFunnelDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsFunnelConnectorWidth ConnectorWidth { get; set; }
		private PlotOptionsFunnelConnectorWidth ConnectorWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the series states.
		/// </summary>
		public PlotOptionsFunnelStates States { get; set; }
		private PlotOptionsFunnelStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for a selected funnel item.
		/// </summary>
		public PlotOptionsFunnelSelect Select { get; set; }
		private PlotOptionsFunnelSelect Select_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsFunnelColor Color { get; set; }
		private PlotOptionsFunnelColor Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsFunnelBorderColor BorderColor { get; set; }
		private PlotOptionsFunnelBorderColor BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (NeckWidth != NeckWidth_DefaultValue) h.Add("neckWidth",NeckWidth);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (NeckHeight != NeckHeight_DefaultValue) h.Add("neckHeight",NeckHeight);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (NeckWidth != NeckWidth_DefaultValue) h.Add("neckWidth",NeckWidth);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (NeckHeight != NeckHeight_DefaultValue) h.Add("neckHeight",NeckHeight);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (ConnectorWidth != ConnectorWidth_DefaultValue) h.Add("connectorWidth",ConnectorWidth);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Select.IsDirty()) h.Add("select",Select.ToHashtable());
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			

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