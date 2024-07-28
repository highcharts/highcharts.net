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
	public partial class XAxisScrollbar  : BaseObject
	{
		Hashtable h = new Hashtable();

		public XAxisScrollbar()
		{
		}	
		

		/// <summary>
		/// The background color of the scrollbar itself.
		/// </summary>
		public string BarBackgroundColor { get; set; }
		 

		/// <summary>
		/// The color of the scrollbar's border.
		/// </summary>
		public string BarBorderColor { get; set; }
		 

		/// <summary>
		/// The border rounding radius of the bar.
		/// </summary>
		public double? BarBorderRadius { get; set; }
		 

		/// <summary>
		/// The width of the bar's border.
		/// </summary>
		public double? BarBorderWidth { get; set; }
		 

		/// <summary>
		/// The color of the small arrow inside the scrollbar buttons.
		/// </summary>
		public string ButtonArrowColor { get; set; }
		 

		/// <summary>
		/// The color of scrollbar buttons.
		/// </summary>
		public string ButtonBackgroundColor { get; set; }
		 

		/// <summary>
		/// The color of the border of the scrollbar buttons.
		/// </summary>
		public string ButtonBorderColor { get; set; }
		 

		/// <summary>
		/// The corner radius of the scrollbar buttons.
		/// </summary>
		public double? ButtonBorderRadius { get; set; }
		 

		/// <summary>
		/// The border width of the scrollbar buttons.
		/// </summary>
		public double? ButtonBorderWidth { get; set; }
		 

		/// <summary>
		/// Enable or disable the buttons at the end of the scrollbar.
		/// </summary>
		public bool? ButtonsEnabled { get; set; }
		 

		/// <summary>
		/// Enable or disable the scrollbar.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// The height of the scrollbar. If `buttonsEnabled` is true , the heightalso applies to the width of the scroll arrows so that they are alwayssquares.
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// Whether to redraw the main chart as the scrollbar or the navigatorzoomed window is moved. Defaults to `true` for modern browsers and`false` for legacy IE browsers as well as mobile devices.
		/// </summary>
		public bool? LiveRedraw { get; set; }
		 

		/// <summary>
		/// The margin between the scrollbar and its axis when the scrollbar isapplied directly to an axis, or the navigator in case that is enabled.Defaults to 10 for axis, 0 for navigator.
		/// </summary>
		public double? Margin { get; set; }
		 

		/// <summary>
		/// The minimum width of the scrollbar.
		/// </summary>
		public double? MinWidth { get; set; }
		 

		/// <summary>
		/// Defines the position of the scrollbar. By default, it is positionedon the opposite of the main axis (right side of the chart).However, in the case of RTL languages could be set to `false`which positions the scrollbar on the left.Works only for vertical axes.This means yAxis in a non-inverted chart and xAxis in the inverted.
		/// </summary>
		public bool? Opposite { get; set; }
		 

		/// <summary>
		/// The color of the small rifles in the middle of the scrollbar.
		/// </summary>
		public string RifleColor { get; set; }
		 

		/// <summary>
		/// Whether to show or hide the scrollbar when the scrolled content iszoomed out to it full extent.
		/// </summary>
		public bool? ShowFull { get; set; }
		 

		/// <summary>
		/// The color of the track background.
		/// </summary>
		public string TrackBackgroundColor { get; set; }
		 

		/// <summary>
		/// The color of the border of the scrollbar track.
		/// </summary>
		public string TrackBorderColor { get; set; }
		 

		/// <summary>
		/// The corner radius of the border of the scrollbar track.
		/// </summary>
		public double? TrackBorderRadius { get; set; }
		 

		/// <summary>
		/// The width of the border of the scrollbar track.
		/// </summary>
		public double? TrackBorderWidth { get; set; }
		 

		/// <summary>
		/// The z index of the scrollbar group.
		/// </summary>
		public double? ZIndex { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (BarBackgroundColor != null) h.Add("barBackgroundColor",BarBackgroundColor);
			if (BarBorderColor != null) h.Add("barBorderColor",BarBorderColor);
			if (BarBorderRadius != null) h.Add("barBorderRadius",BarBorderRadius);
			if (BarBorderWidth != null) h.Add("barBorderWidth",BarBorderWidth);
			if (ButtonArrowColor != null) h.Add("buttonArrowColor",ButtonArrowColor);
			if (ButtonBackgroundColor != null) h.Add("buttonBackgroundColor",ButtonBackgroundColor);
			if (ButtonBorderColor != null) h.Add("buttonBorderColor",ButtonBorderColor);
			if (ButtonBorderRadius != null) h.Add("buttonBorderRadius",ButtonBorderRadius);
			if (ButtonBorderWidth != null) h.Add("buttonBorderWidth",ButtonBorderWidth);
			if (ButtonsEnabled != null) h.Add("buttonsEnabled",ButtonsEnabled);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Height != null) h.Add("height",Height);
			if (LiveRedraw != null) h.Add("liveRedraw",LiveRedraw);
			if (Margin != null) h.Add("margin",Margin);
			if (MinWidth != null) h.Add("minWidth",MinWidth);
			if (Opposite != null) h.Add("opposite",Opposite);
			if (RifleColor != null) h.Add("rifleColor",RifleColor);
			if (ShowFull != null) h.Add("showFull",ShowFull);
			if (TrackBackgroundColor != null) h.Add("trackBackgroundColor",TrackBackgroundColor);
			if (TrackBorderColor != null) h.Add("trackBorderColor",TrackBorderColor);
			if (TrackBorderRadius != null) h.Add("trackBorderRadius",TrackBorderRadius);
			if (TrackBorderWidth != null) h.Add("trackBorderWidth",TrackBorderWidth);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
			if (CustomFields != null && CustomFields.Count > 0)
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