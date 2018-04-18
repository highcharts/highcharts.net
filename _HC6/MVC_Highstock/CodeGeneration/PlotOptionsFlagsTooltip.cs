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
	public partial class PlotOptionsFlagsTooltip  : BaseObject
	{
		public PlotOptionsFlagsTooltip()
		{
			PointFormat = PointFormat_DefaultValue = "{point.text}<br/>";
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = new Hashtable();
			FooterFormat = FooterFormat_DefaultValue = "";
			Padding = Padding_DefaultValue = "8";
			HeaderFormat = HeaderFormat_DefaultValue = "<span style='font-size: 10px'>{point.key}</span><br/>";
			FollowPointer = FollowPointer_DefaultValue = null;
			FollowTouchMove = FollowTouchMove_DefaultValue = null;
			HideDelay = HideDelay_DefaultValue = 500;
			PointFormatter = PointFormatter_DefaultValue = "";
			Split = Split_DefaultValue = null;
			XDateFormat = XDateFormat_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// For series on a datetime axes, the date format in the tooltip'sheader will by default be guessed based on the closest data points.This member gives the default string representations used foreach unit. For an overview of the replacement codes, see [dateFormat](#Highcharts.dateFormat).Defaults to:<pre>{    millisecond:"%A, %b %e, %H:%M:%S.%L",    second:"%A, %b %e, %H:%M:%S",    minute:"%A, %b %e, %H:%M",    hour:"%A, %b %e, %H:%M",    day:"%A, %b %e, %Y",    week:"Week from %A, %b %e, %Y",    month:"%B %Y",    year:"%Y"}</pre>
		/// </summary>
		public Hashtable DateTimeLabelFormats { get; set; }
		private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// A string to append to the tooltip format.
		/// </summary>
		public string FooterFormat { get; set; }
		private string FooterFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding inside the tooltip, in pixels.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML of the tooltip header line. Variables are enclosed bycurly brackets. Available variables are `point.key`, `series.name`,`series.color` and other members from the `point` and `series`objects. The `point.key` variable contains the category name, xvalue or datetime string depending on the type of axis. For datetimeaxes, the `point.key` date format can be set using tooltip.xDateFormat.
		/// </summary>
		public string HeaderFormat { get; set; }
		private string HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should follow the mouse as it moves across columns,pie slices and other point types with an extent. By default it behavesthis way for scatter, bubble and pie series by override in the `plotOptions`for those series types.For touch moves to behave the same way, [followTouchMove](#tooltip.followTouchMove) must be `true` also.
		/// </summary>
		public bool? FollowPointer { get; set; }
		private bool? FollowPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should follow the finger as it moves on a touchdevice. If this is `true` and [chart.panning](#chart.panning) isset,`followTouchMove` will take over one-finger touches, so the userneeds to use two fingers for zooming and panning.
		/// </summary>
		public bool? FollowTouchMove { get; set; }
		private bool? FollowTouchMove_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of milliseconds to wait until the tooltip is hidden whenmouse out from a point or chart.
		/// </summary>
		public double? HideDelay { get; set; }
		private double? HideDelay_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function for formatting the HTML output for a single pointin the tooltip. Like the `pointFormat` string, but with more flexibility.
		/// </summary>
		public string PointFormatter { get; set; }
		private string PointFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Split the tooltip into one label per series, with the header closeto the axis. This is recommended over [shared](#tooltip.shared) tooltipsfor charts with multiple line series, generally making them easierto read. This option takes precedence over `tooltip.shared`.
		/// </summary>
		public bool? Split { get; set; }
		private bool? Split_DefaultValue { get; set; }
		 

		/// <summary>
		/// The format for the date in the tooltip header if the X axis is adatetime axis. The default is a best guess based on the smallestdistance between points in the chart.
		/// </summary>
		public string XDateFormat { get; set; }
		private string XDateFormat_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (DateTimeLabelFormats != DateTimeLabelFormats_DefaultValue) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (FooterFormat != FooterFormat_DefaultValue) h.Add("footerFormat",FooterFormat);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (FollowTouchMove != FollowTouchMove_DefaultValue) h.Add("followTouchMove",FollowTouchMove);
			if (HideDelay != HideDelay_DefaultValue) h.Add("hideDelay",HideDelay);
			if (PointFormatter != PointFormatter_DefaultValue) { h.Add("pointFormatter",PointFormatter); Highstock.AddFunction("PlotOptionsFlagsTooltipPointFormatter.pointFormatter", PointFormatter); }  
			if (Split != Split_DefaultValue) h.Add("split",Split);
			if (XDateFormat != XDateFormat_DefaultValue) h.Add("xDateFormat",XDateFormat);
			

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