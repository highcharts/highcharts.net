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
	public partial class PlotOptionsCmfTooltip  : BaseObject
	{
		public PlotOptionsCmfTooltip()
		{
			ValueDecimals = ValueDecimals_DefaultValue = null;
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = new PlotOptionsCmfTooltipDateTimeLabelFormats();
			Padding = Padding_DefaultValue = 8;
			HeaderFormat = HeaderFormat_DefaultValue = "<span style='font-size: 10px'>{point.key}</span><br/>";
			PointFormat = PointFormat_DefaultValue = "<span style='color:{point.color}'>\u25CF</span> {series.name}: <b>{point.y}</b><br/>";
			FollowPointer = FollowPointer_DefaultValue = null;
			FollowTouchMove = FollowTouchMove_DefaultValue = null;
			PointFormatter = PointFormatter_DefaultValue = "";
			Split = Split_DefaultValue = null;
			ValuePrefix = ValuePrefix_DefaultValue = null;
			ValueSuffix = ValueSuffix_DefaultValue = null;
			XDateFormat = XDateFormat_DefaultValue = null;
			ChangeDecimals = ChangeDecimals_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Number of decimals in indicator series.</p>
		/// </summary>
		public double? ValueDecimals { get; set; }
		private double? ValueDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For series on a datetime axes, the date format in the tooltip&#39;sheader will by default be guessed based on the closest data points.This member gives the default string representations used foreach unit. For an overview of the replacement codes, see <a href="#Highcharts.dateFormat">dateFormat</a>.</p><p>Defaults to:</p><pre>{    millisecond:"%A, %b %e, %H:%M:%S.%L",    second:"%A, %b %e, %H:%M:%S",    minute:"%A, %b %e, %H:%M",    hour:"%A, %b %e, %H:%M",    day:"%A, %b %e, %Y",    week:"Week from %A, %b %e, %Y",    month:"%B %Y",    year:"%Y"}</pre>
		/// </summary>
		public PlotOptionsCmfTooltipDateTimeLabelFormats DateTimeLabelFormats { get; set; }
		private PlotOptionsCmfTooltipDateTimeLabelFormats DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Padding inside the tooltip, in pixels.</p>
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The HTML of the tooltip header line. Variables are enclosed bycurly brackets. Available variables are <code>point.key</code>, <code>series.name</code>,<code>series.color</code> and other members from the <code>point</code> and <code>series</code>objects. The <code>point.key</code> variable contains the category name, xvalue or datetime string depending on the type of axis. For datetimeaxes, the <code>point.key</code> date format can be set using tooltip.xDateFormat.</p>
		/// </summary>
		public string HeaderFormat { get; set; }
		private string HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The HTML of the point&#39;s line in the tooltip. Variables are enclosedby curly brackets. Available variables are point.x, point.y, series.name and series.color and other properties on the same form. Furthermore,point.y can be extended by the <code>tooltip.valuePrefix</code> and <code>tooltip.valueSuffix</code> variables. This can also be overridden for each series,which makes it a good hook for displaying units.</p><p>In styled mode, the dot is colored by a class name ratherthan the point color.</p>
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether the tooltip should follow the mouse as it moves across columns,pie slices and other point types with an extent. By default it behavesthis way for scatter, bubble and pie series by override in the <code>plotOptions</code>for those series types.</p><p>For touch moves to behave the same way, <a href="#tooltip.followTouchMove">followTouchMove</a> must be <code>true</code> also.</p>
		/// </summary>
		public bool? FollowPointer { get; set; }
		private bool? FollowPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether the tooltip should follow the finger as it moves on a touchdevice. If this is <code>true</code> and <a href="#chart.panning">chart.panning</a> isset,<code>followTouchMove</code> will take over one-finger touches, so the userneeds to use two fingers for zooming and panning.</p>
		/// </summary>
		public bool? FollowTouchMove { get; set; }
		private bool? FollowTouchMove_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A callback function for formatting the HTML output for a single pointin the tooltip. Like the <code>pointFormat</code> string, but with more flexibility.</p>
		/// </summary>
		public string PointFormatter { get; set; }
		private string PointFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Split the tooltip into one label per series, with the header closeto the axis. This is recommended over <a href="#tooltip.shared">shared</a> tooltipsfor charts with multiple line series, generally making them easierto read.</p>
		/// </summary>
		public bool? Split { get; set; }
		private bool? Split_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A string to prepend to each series&#39; y value. Overridable in eachseries&#39; tooltip options object.</p>
		/// </summary>
		public string ValuePrefix { get; set; }
		private string ValuePrefix_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A string to append to each series&#39; y value. Overridable in each series&#39;tooltip options object.</p>
		/// </summary>
		public string ValueSuffix { get; set; }
		private string ValueSuffix_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The format for the date in the tooltip header if the X axis is adatetime axis. The default is a best guess based on the smallestdistance between points in the chart.</p>
		/// </summary>
		public string XDateFormat { get; set; }
		private string XDateFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>How many decimals to show for the <code>point.change</code> value when the <code>series.compare</code> option is set. This is overridable in each series&#39; tooltipoptions object. The default is to preserve all decimals.</p>
		/// </summary>
		public double? ChangeDecimals { get; set; }
		private double? ChangeDecimals_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ValueDecimals != ValueDecimals_DefaultValue) h.Add("valueDecimals",ValueDecimals);
			if (DateTimeLabelFormats.IsDirty()) h.Add("dateTimeLabelFormats",DateTimeLabelFormats.ToHashtable());
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (FollowTouchMove != FollowTouchMove_DefaultValue) h.Add("followTouchMove",FollowTouchMove);
			if (PointFormatter != PointFormatter_DefaultValue) h.Add("pointFormatter",PointFormatter);
			if (Split != Split_DefaultValue) h.Add("split",Split);
			if (ValuePrefix != ValuePrefix_DefaultValue) h.Add("valuePrefix",ValuePrefix);
			if (ValueSuffix != ValueSuffix_DefaultValue) h.Add("valueSuffix",ValueSuffix);
			if (XDateFormat != XDateFormat_DefaultValue) h.Add("xDateFormat",XDateFormat);
			if (ChangeDecimals != ChangeDecimals_DefaultValue) h.Add("changeDecimals",ChangeDecimals);
			

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