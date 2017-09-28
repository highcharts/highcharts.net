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
	public partial class YAxisScrollbar  : BaseObject
	{
		public YAxisScrollbar()
		{
			BarBackgroundColor = BarBackgroundColor_DefaultValue = "#cccccc";
			BarBorderColor = BarBorderColor_DefaultValue = "#cccccc";
			BarBorderRadius = BarBorderRadius_DefaultValue = 0;
			BarBorderWidth = BarBorderWidth_DefaultValue = 1;
			ButtonArrowColor = ButtonArrowColor_DefaultValue = "#333333";
			ButtonBackgroundColor = ButtonBackgroundColor_DefaultValue = "#e6e6e6";
			ButtonBorderColor = ButtonBorderColor_DefaultValue = "#cccccc";
			ButtonBorderRadius = ButtonBorderRadius_DefaultValue = 0;
			ButtonBorderWidth = ButtonBorderWidth_DefaultValue = 1;
			Enabled = Enabled_DefaultValue = false;
			LiveRedraw = LiveRedraw_DefaultValue = true;
			Margin = Margin_DefaultValue = null;
			MinWidth = MinWidth_DefaultValue = 6;
			RifleColor = RifleColor_DefaultValue = "#333333";
			ShowFull = ShowFull_DefaultValue = true;
			Size = Size_DefaultValue = 14;
			TrackBackgroundColor = TrackBackgroundColor_DefaultValue = "#f2f2f2";
			TrackBorderColor = TrackBorderColor_DefaultValue = "#f2f2f2";
			TrackBorderRadius = TrackBorderRadius_DefaultValue = 0;
			TrackBorderWidth = TrackBorderWidth_DefaultValue = 1;
			ZIndex = ZIndex_DefaultValue = 3;
			
		}	
		

		/// <summary>
		/// The background color of the scrollbar itself.
		/// </summary>
		public string BarBackgroundColor { get; set; }
		private string BarBackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the scrollbar's border.
		/// </summary>
		public string BarBorderColor { get; set; }
		private string BarBorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border rounding radius of the bar.
		/// </summary>
		public double? BarBorderRadius { get; set; }
		private double? BarBorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the bar's border.
		/// </summary>
		public double? BarBorderWidth { get; set; }
		private double? BarBorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the small arrow inside the scrollbar buttons.
		/// </summary>
		public string ButtonArrowColor { get; set; }
		private string ButtonArrowColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of scrollbar buttons.
		/// </summary>
		public string ButtonBackgroundColor { get; set; }
		private string ButtonBackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border of the scrollbar buttons.
		/// </summary>
		public string ButtonBorderColor { get; set; }
		private string ButtonBorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The corner radius of the scrollbar buttons.
		/// </summary>
		public double? ButtonBorderRadius { get; set; }
		private double? ButtonBorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width of the scrollbar buttons.
		/// </summary>
		public double? ButtonBorderWidth { get; set; }
		private double? ButtonBorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable the scrollbar on the Y axis.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to redraw the main chart as the scrollbar or the navigator zoomed window is moved. Defaults to <code>true</code> for modern browsers and <code>false</code> for legacy IE browsers as well as mobile devices.
		/// </summary>
		public bool? LiveRedraw { get; set; }
		private bool? LiveRedraw_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel margin between the scrollbar and the axis elements.
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum width of the scrollbar.
		/// </summary>
		public double? MinWidth { get; set; }
		private double? MinWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the small rifles in the middle of the scrollbar.
		/// </summary>
		public string RifleColor { get; set; }
		private string RifleColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to show the scrollbar when it is fully zoomed out at max range. Setting it to <code>false</code> on the Y axis makes the scrollbar stay hidden until the user zooms in, like common in browsers.
		/// </summary>
		public bool? ShowFull { get; set; }
		private bool? ShowFull_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of a vertical scrollbar or height of a horizontal scrollbar. Defaults to 20 on touch devices.
		/// </summary>
		public double? Size { get; set; }
		private double? Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the track background.
		/// </summary>
		public string TrackBackgroundColor { get; set; }
		private string TrackBackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border of the scrollbar track.
		/// </summary>
		public string TrackBorderColor { get; set; }
		private string TrackBorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The corner radius of the border of the scrollbar track.
		/// </summary>
		public double? TrackBorderRadius { get; set; }
		private double? TrackBorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the border of the scrollbar track.
		/// </summary>
		public double? TrackBorderWidth { get; set; }
		private double? TrackBorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Z index of the scrollbar elements.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BarBackgroundColor != BarBackgroundColor_DefaultValue) h.Add("barBackgroundColor",BarBackgroundColor);
			if (BarBorderColor != BarBorderColor_DefaultValue) h.Add("barBorderColor",BarBorderColor);
			if (BarBorderRadius != BarBorderRadius_DefaultValue) h.Add("barBorderRadius",BarBorderRadius);
			if (BarBorderWidth != BarBorderWidth_DefaultValue) h.Add("barBorderWidth",BarBorderWidth);
			if (ButtonArrowColor != ButtonArrowColor_DefaultValue) h.Add("buttonArrowColor",ButtonArrowColor);
			if (ButtonBackgroundColor != ButtonBackgroundColor_DefaultValue) h.Add("buttonBackgroundColor",ButtonBackgroundColor);
			if (ButtonBorderColor != ButtonBorderColor_DefaultValue) h.Add("buttonBorderColor",ButtonBorderColor);
			if (ButtonBorderRadius != ButtonBorderRadius_DefaultValue) h.Add("buttonBorderRadius",ButtonBorderRadius);
			if (ButtonBorderWidth != ButtonBorderWidth_DefaultValue) h.Add("buttonBorderWidth",ButtonBorderWidth);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (LiveRedraw != LiveRedraw_DefaultValue) h.Add("liveRedraw",LiveRedraw);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (MinWidth != MinWidth_DefaultValue) h.Add("minWidth",MinWidth);
			if (RifleColor != RifleColor_DefaultValue) h.Add("rifleColor",RifleColor);
			if (ShowFull != ShowFull_DefaultValue) h.Add("showFull",ShowFull);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (TrackBackgroundColor != TrackBackgroundColor_DefaultValue) h.Add("trackBackgroundColor",TrackBackgroundColor);
			if (TrackBorderColor != TrackBorderColor_DefaultValue) h.Add("trackBorderColor",TrackBorderColor);
			if (TrackBorderRadius != TrackBorderRadius_DefaultValue) h.Add("trackBorderRadius",TrackBorderRadius);
			if (TrackBorderWidth != TrackBorderWidth_DefaultValue) h.Add("trackBorderWidth",TrackBorderWidth);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

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