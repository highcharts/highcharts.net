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
	public partial class PlotOptionsWaterfall  : BaseObject
	{
		public PlotOptionsWaterfall()
		{
			LineWidth = LineWidth_DefaultValue = 1;
			LineColor = LineColor_DefaultValue = "#333333";
			DashStyle = DashStyle_DefaultValue = "Dot";
			BorderColor = BorderColor_DefaultValue = "#333333";
			States = States_DefaultValue = null;
			UpColor = UpColor_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = "";
			Inside = Inside_DefaultValue = True;
			LineWidth = LineWidth_DefaultValue = 1;
			LineColor = LineColor_DefaultValue = "#333333";
			DashStyle = DashStyle_DefaultValue = "Dot";
			BorderColor = BorderColor_DefaultValue = "#333333";
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			LineWidthPlus = LineWidthPlus_DefaultValue = 0;
			UpColor = UpColor_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// The width of the line connecting waterfall columns.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the line that connects columns in a waterfall series.In styled mode, the stroke can be set with the `.highcharts-graph` class.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A name for the dash style to use for the line connecting the columnsof the waterfall series. Possible values:*   Solid*   ShortDash*   ShortDot*   ShortDashDot*   ShortDashDotDot*   Dot*   Dash*   LongDash*   DashDot*   LongDashDot*   LongDashDotDotIn styled mode, the stroke dash-array can be set with the `.highcharts-graph` class.
		/// </summary>
		public string DashStyle { get; set; }
		private string DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border of each waterfall column.In styled mode, the border stroke can be set with the `.highcharts-point` class.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWaterfallStates States { get; set; }
		private PlotOptionsWaterfallStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color used specifically for positive point columns. When notspecified, the general series color is used.In styled mode, the waterfall colors can be set with the`.highcharts-point-negative`, `.highcharts-sum` and`.highcharts-intermediate-sum` classes.
		/// </summary>
		public string UpColor { get; set; }
		private string UpColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWaterfallDataLabels DataLabels { get; set; }
		private PlotOptionsWaterfallDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWaterfallInside Inside { get; set; }
		private PlotOptionsWaterfallInside Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the line connecting waterfall columns.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the line that connects columns in a waterfall series.In styled mode, the stroke can be set with the `.highcharts-graph` class.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// A name for the dash style to use for the line connecting the columnsof the waterfall series. Possible values:*   Solid*   ShortDash*   ShortDot*   ShortDashDot*   ShortDashDotDot*   Dot*   Dash*   LongDash*   DashDot*   LongDashDot*   LongDashDotDotIn styled mode, the stroke dash-array can be set with the `.highcharts-graph` class.
		/// </summary>
		public string DashStyle { get; set; }
		private string DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the border of each waterfall column.In styled mode, the border stroke can be set with the `.highcharts-point` class.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWaterfallStates States { get; set; }
		private PlotOptionsWaterfallStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWaterfallHover Hover { get; set; }
		private PlotOptionsWaterfallHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWaterfallLineWidthPlus LineWidthPlus { get; set; }
		private PlotOptionsWaterfallLineWidthPlus LineWidthPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color used specifically for positive point columns. When notspecified, the general series color is used.In styled mode, the waterfall colors can be set with the`.highcharts-point-negative`, `.highcharts-sum` and`.highcharts-intermediate-sum` classes.
		/// </summary>
		public string UpColor { get; set; }
		private string UpColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle",DashStyle);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (UpColor != UpColor_DefaultValue) h.Add("upColor",UpColor);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle",DashStyle);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (LineWidthPlus != LineWidthPlus_DefaultValue) h.Add("lineWidthPlus",LineWidthPlus);
			if (UpColor != UpColor_DefaultValue) h.Add("upColor",UpColor);
			

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