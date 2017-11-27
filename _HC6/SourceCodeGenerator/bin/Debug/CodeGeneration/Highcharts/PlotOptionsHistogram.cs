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
	public partial class PlotOptionsHistogram  : BaseObject
	{
		public PlotOptionsHistogram()
		{
			BinsNumber = BinsNumber_DefaultValue = "square-root";
			BinWidth = BinWidth_DefaultValue = null;
			PointPadding = PointPadding_DefaultValue = 0;
			GroupPadding = GroupPadding_DefaultValue = 0;
			Grouping = Grouping_DefaultValue = False;
			PointPlacement = PointPlacement_DefaultValue = new PointPlacement();
			Tooltip = Tooltip_DefaultValue = null;
			BinsNumber = BinsNumber_DefaultValue = "square-root";
			BinWidth = BinWidth_DefaultValue = null;
			PointPadding = PointPadding_DefaultValue = 0;
			GroupPadding = GroupPadding_DefaultValue = 0;
			Grouping = Grouping_DefaultValue = False;
			PointPlacement = PointPlacement_DefaultValue = new PointPlacement();
			Tooltip = Tooltip_DefaultValue = "";
			HeaderFormat = HeaderFormat_DefaultValue = "";
			PointFormat = PointFormat_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// A preferable number of bins. It is a suggestion, so a histogram may havea different number of bins. By default it is set to the square of thebase series' data length. Available options are: `square-root`,`sturges`, `rice`. You can also define a function which takes a`baseSeries` as a parameter and should return a positive integer.
		/// </summary>
		public string BinsNumber { get; set; }
		private string BinsNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width of each bin. By default the bin's width is calculated as `(max - min) / number of bins`.This option takes precedence over [binsNumber](#plotOptions.histogram.binsNumber).
		/// </summary>
		public double? BinWidth { get; set; }
		private double? BinWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHistogramPointPadding PointPadding { get; set; }
		private PlotOptionsHistogramPointPadding PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHistogramGroupPadding GroupPadding { get; set; }
		private PlotOptionsHistogramGroupPadding GroupPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHistogramGrouping Grouping { get; set; }
		private PlotOptionsHistogramGrouping Grouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PointPlacement PointPlacement { get; set; }
		private PointPlacement PointPlacement_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHistogramTooltip Tooltip { get; set; }
		private PlotOptionsHistogramTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// A preferable number of bins. It is a suggestion, so a histogram may havea different number of bins. By default it is set to the square of thebase series' data length. Available options are: `square-root`,`sturges`, `rice`. You can also define a function which takes a`baseSeries` as a parameter and should return a positive integer.
		/// </summary>
		public string BinsNumber { get; set; }
		private string BinsNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width of each bin. By default the bin's width is calculated as `(max - min) / number of bins`.This option takes precedence over [binsNumber](#plotOptions.histogram.binsNumber).
		/// </summary>
		public double? BinWidth { get; set; }
		private double? BinWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHistogramPointPadding PointPadding { get; set; }
		private PlotOptionsHistogramPointPadding PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHistogramGroupPadding GroupPadding { get; set; }
		private PlotOptionsHistogramGroupPadding GroupPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHistogramGrouping Grouping { get; set; }
		private PlotOptionsHistogramGrouping Grouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PointPlacement PointPlacement { get; set; }
		private PointPlacement PointPlacement_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHistogramTooltip Tooltip { get; set; }
		private PlotOptionsHistogramTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHistogramHeaderFormat HeaderFormat { get; set; }
		private PlotOptionsHistogramHeaderFormat HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHistogramPointFormat PointFormat { get; set; }
		private PlotOptionsHistogramPointFormat PointFormat_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BinsNumber != BinsNumber_DefaultValue) h.Add("binsNumber",BinsNumber);
			if (BinWidth != BinWidth_DefaultValue) h.Add("binWidth",BinWidth);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (GroupPadding != GroupPadding_DefaultValue) h.Add("groupPadding",GroupPadding);
			if (Grouping != Grouping_DefaultValue) h.Add("grouping",Grouping);
			if (PointPlacement.IsDirty())
				if (PointPlacement.Value.HasValue)
					h.Add("pointPlacement", PointPlacement.Value);
				else
					h.Add("pointPlacement", PointPlacement.ToJSON());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (BinsNumber != BinsNumber_DefaultValue) h.Add("binsNumber",BinsNumber);
			if (BinWidth != BinWidth_DefaultValue) h.Add("binWidth",BinWidth);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (GroupPadding != GroupPadding_DefaultValue) h.Add("groupPadding",GroupPadding);
			if (Grouping != Grouping_DefaultValue) h.Add("grouping",Grouping);
			if (PointPlacement.IsDirty())
				if (PointPlacement.Value.HasValue)
					h.Add("pointPlacement", PointPlacement.Value);
				else
					h.Add("pointPlacement", PointPlacement.ToJSON());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			

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