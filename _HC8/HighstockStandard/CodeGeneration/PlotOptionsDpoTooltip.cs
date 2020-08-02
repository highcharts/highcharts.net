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
	public partial class PlotOptionsDpoTooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsDpoTooltip()
		{
			ChangeDecimals = ChangeDecimals_DefaultValue = null;
			ClusterFormat = ClusterFormat_DefaultValue = "";
			DateTimeLabelFormats = DateTimeLabelFormats_DefaultValue = new Hashtable();
			Distance = Distance_DefaultValue = 16;
			FollowPointer = FollowPointer_DefaultValue = null;
			FollowTouchMove = FollowTouchMove_DefaultValue = null;
			FooterFormat = FooterFormat_DefaultValue = "";
			HeaderFormat = HeaderFormat_DefaultValue = "<span style='font-size: 10px'>{point.key}</span><br/>";
			NullFormat = NullFormat_DefaultValue = "";
			NullFormatter = NullFormatter_DefaultValue = "";
			PointFormat = PointFormat_DefaultValue = "<span style='color:{point.color}'>●</span> {series.name}: <b>{point.y}</b><br/>";
			PointFormatter = PointFormatter_DefaultValue = "";
			StickOnContact = StickOnContact_DefaultValue = null;
			ValueDecimals = ValueDecimals_DefaultValue = null;
			ValuePrefix = ValuePrefix_DefaultValue = "";
			ValueSuffix = ValueSuffix_DefaultValue = "";
			XDateFormat = XDateFormat_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// How many decimals to show for the `point.change` value when the`series.compare` option is set. This is overridable in each series'tooltip options object. The default is to preserve all decimals.
		/// </summary>
		public double? ChangeDecimals { get; set; }
		private double? ChangeDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML of the cluster point's in the tooltip. Works only withmarker-clusters module and analogously to[pointFormat](#tooltip.pointFormat).The cluster tooltip can be also formatted using`tooltip.formatter` callback function and `point.isCluster` flag.
		/// </summary>
		public object ClusterFormat { get; set; }
		private object ClusterFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// For series on a datetime axes, the date format in the tooltip'sheader will by default be guessed based on the closest data points.This member gives the default string representations used foreach unit. For an overview of the replacement codes, see[dateFormat](/class-reference/Highcharts#dateFormat).
		/// </summary>
		public Hashtable DateTimeLabelFormats { get; set; }
		private Hashtable DateTimeLabelFormats_DefaultValue { get; set; }
		 

		/// <summary>
		/// Distance from point to tooltip in pixels.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should follow the mouse as it moves acrosscolumns, pie slices and other point types with an extent.By default it behaves this way for pie, polygon, map, sankeyand wordcloud series by override in the `plotOptions`for those series types.For touch moves to behave the same way, [followTouchMove](#tooltip.followTouchMove) must be `true` also.
		/// </summary>
		public bool? FollowPointer { get; set; }
		private bool? FollowPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should update as the finger moves on a touchdevice. If this is `true` and [chart.panning](#chart.panning) isset,`followTouchMove` will take over one-finger touches, so the userneeds to use two fingers for zooming and panning.Note the difference to [followPointer](#tooltip.followPointer) thatonly defines the _position_ of the tooltip. If `followPointer` isfalse in for example a column series, the tooltip will show above orbelow the column, but as `followTouchMove` is true, the tooltip willjump from column to column as the user swipes across the plot area.
		/// </summary>
		public bool? FollowTouchMove { get; set; }
		private bool? FollowTouchMove_DefaultValue { get; set; }
		 

		/// <summary>
		/// A string to append to the tooltip format.
		/// </summary>
		public string FooterFormat { get; set; }
		private string FooterFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML of the tooltip header line. Variables are enclosed bycurly brackets. Available variables are `point.key`, `series.name`,`series.color` and other members from the `point` and `series`objects. The `point.key` variable contains the category name, xvalue or datetime string depending on the type of axis. For datetimeaxes, the `point.key` date format can be set using`tooltip.xDateFormat`.
		/// </summary>
		public string HeaderFormat { get; set; }
		private string HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML of the null point's line in the tooltip. Works analogouslyto [pointFormat](#tooltip.pointFormat).
		/// </summary>
		public string NullFormat { get; set; }
		private string NullFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback function to format the text of the tooltip forvisible null points.Works analogously to [formatter](#tooltip.formatter).
		/// </summary>
		public string NullFormatter { get; set; }
		private string NullFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// The HTML of the point's line in the tooltip. Variables are enclosedby curly brackets. Available variables are point.x, point.y, series.name and series.color and other properties on the same form.Furthermore, `point.y` can be extended by the `tooltip.valuePrefix`and `tooltip.valueSuffix` variables. This can also be overridden foreach series, which makes it a good hook for displaying units.In styled mode, the dot is colored by a class name ratherthan the point color.
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback function for formatting the HTML output for a single pointin the tooltip. Like the `pointFormat` string, but with moreflexibility.
		/// </summary>
		public string PointFormatter { get; set; }
		private string PointFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Prevents the tooltip from switching or closing, when touched orpointed.
		/// </summary>
		public bool? StickOnContact { get; set; }
		private bool? StickOnContact_DefaultValue { get; set; }
		 

		/// <summary>
		/// How many decimals to show in each series' y value. This isoverridable in each series' tooltip options object. The default is topreserve all decimals.
		/// </summary>
		public double? ValueDecimals { get; set; }
		private double? ValueDecimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// A string to prepend to each series' y value. Overridable in eachseries' tooltip options object.
		/// </summary>
		public string ValuePrefix { get; set; }
		private string ValuePrefix_DefaultValue { get; set; }
		 

		/// <summary>
		/// A string to append to each series' y value. Overridable in eachseries' tooltip options object.
		/// </summary>
		public string ValueSuffix { get; set; }
		private string ValueSuffix_DefaultValue { get; set; }
		 

		/// <summary>
		/// The format for the date in the tooltip header if the X axis is adatetime axis. The default is a best guess based on the smallestdistance between points in the chart.
		/// </summary>
		public string XDateFormat { get; set; }
		private string XDateFormat_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (ChangeDecimals != ChangeDecimals_DefaultValue) h.Add("changeDecimals",ChangeDecimals);
			if (ClusterFormat.IsDirty()) h.Add("clusterFormat",ClusterFormat.ToHashtable());
			if (DateTimeLabelFormats != DateTimeLabelFormats_DefaultValue) h.Add("dateTimeLabelFormats",DateTimeLabelFormats);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (FollowTouchMove != FollowTouchMove_DefaultValue) h.Add("followTouchMove",FollowTouchMove);
			if (FooterFormat != FooterFormat_DefaultValue) h.Add("footerFormat",FooterFormat);
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (NullFormat != NullFormat_DefaultValue) h.Add("nullFormat",NullFormat);
			if (NullFormatter != NullFormatter_DefaultValue) { h.Add("nullFormatter",NullFormatter); Highstock.AddFunction("PlotOptionsDpoTooltipNullFormatter.nullFormatter", NullFormatter); }  
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (PointFormatter != PointFormatter_DefaultValue) { h.Add("pointFormatter",PointFormatter); Highstock.AddFunction("PlotOptionsDpoTooltipPointFormatter.pointFormatter", PointFormatter); }  
			if (StickOnContact != StickOnContact_DefaultValue) h.Add("stickOnContact",StickOnContact);
			if (ValueDecimals != ValueDecimals_DefaultValue) h.Add("valueDecimals",ValueDecimals);
			if (ValuePrefix != ValuePrefix_DefaultValue) h.Add("valuePrefix",ValuePrefix);
			if (ValueSuffix != ValueSuffix_DefaultValue) h.Add("valueSuffix",ValueSuffix);
			if (XDateFormat != XDateFormat_DefaultValue) h.Add("xDateFormat",XDateFormat);
			

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