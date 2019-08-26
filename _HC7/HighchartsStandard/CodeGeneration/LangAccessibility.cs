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
	public partial class LangAccessibility  : BaseObject
	{
		public LangAccessibility()
		{
			AnnounceNewData = AnnounceNewData_DefaultValue = new LangAccessibilityAnnounceNewData();
			Axis = Axis_DefaultValue = new LangAccessibilityAxis();
			ChartContainerLabel = ChartContainerLabel_DefaultValue = "{title}. Highcharts interactive chart.";
			ChartHeading = ChartHeading_DefaultValue = "Chart graphic.";
			ChartTypes = ChartTypes_DefaultValue = new LangAccessibilityChartTypes();
			Credits = Credits_DefaultValue = "Chart credits: {creditsStr}";
			DefaultChartTitle = DefaultChartTitle_DefaultValue = "Chart";
			DrillUpButton = DrillUpButton_DefaultValue = "{buttonText}";
			Exporting = Exporting_DefaultValue = new LangAccessibilityExporting();
			LegendItem = LegendItem_DefaultValue = "Toggle visibility of {itemName}";
			LegendLabel = LegendLabel_DefaultValue = "Toggle series visibility";
			MapZoomIn = MapZoomIn_DefaultValue = "Zoom chart";
			MapZoomOut = MapZoomOut_DefaultValue = "Zoom out chart";
			RangeSelectorButton = RangeSelectorButton_DefaultValue = "Select range {buttonText}";
			RangeSelectorMaxInput = RangeSelectorMaxInput_DefaultValue = "Select end date.";
			RangeSelectorMinInput = RangeSelectorMinInput_DefaultValue = "Select start date.";
			ResetZoomButton = ResetZoomButton_DefaultValue = "Reset zoom";
			ScreenReaderRegionLabel = ScreenReaderRegionLabel_DefaultValue = "Chart screen reader information.";
			Series = Series_DefaultValue = new LangAccessibilitySeries();
			SeriesTypeDescriptions = SeriesTypeDescriptions_DefaultValue = new LangAccessibilitySeriesTypeDescriptions();
			SvgContainerEnd = SvgContainerEnd_DefaultValue = "End of interactive chart";
			SvgContainerLabel = SvgContainerLabel_DefaultValue = "Interactive chart";
			SvgContainerTitle = SvgContainerTitle_DefaultValue = "";
			TableSummary = TableSummary_DefaultValue = "Table representation of chart.";
			ThousandsSep = ThousandsSep_DefaultValue = ",";
			ViewAsDataTable = ViewAsDataTable_DefaultValue = "View as data table.";
			
		}	
		

		/// <summary>
		/// Default announcement for new data in charts. If addPoint oraddSeries is used, and only one series/point is added, the`newPointAnnounce` and `newSeriesAnnounce` strings are used.The `...Single` versions will be used if there is only one charton the page, and the `...Multiple` versions will be used if thereare multiple charts on the page. For all other new data events,the `newDataAnnounce` string will be used.
		/// </summary>
		public LangAccessibilityAnnounceNewData AnnounceNewData { get; set; }
		private LangAccessibilityAnnounceNewData AnnounceNewData_DefaultValue { get; set; }
		 

		/// <summary>
		/// Axis description format strings.
		/// </summary>
		public LangAccessibilityAxis Axis { get; set; }
		private LangAccessibilityAxis Axis_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ChartContainerLabel { get; set; }
		private string ChartContainerLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ChartHeading { get; set; }
		private string ChartHeading_DefaultValue { get; set; }
		 

		/// <summary>
		/// Chart type description strings. This is added to the chartinformation region.If there is only a single series type used in the chart, we usethe format string for the series type, or default if missing.There is one format string for cases where there is only a singleseries in the chart, and one for multiple series of the sametype.
		/// </summary>
		public LangAccessibilityChartTypes ChartTypes { get; set; }
		private LangAccessibilityChartTypes ChartTypes_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Credits { get; set; }
		private string Credits_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DefaultChartTitle { get; set; }
		private string DefaultChartTitle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DrillUpButton { get; set; }
		private string DrillUpButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exporting menu format strings for accessibility module.
		/// </summary>
		public LangAccessibilityExporting Exporting { get; set; }
		private LangAccessibilityExporting Exporting_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LegendItem { get; set; }
		private string LegendItem_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LegendLabel { get; set; }
		private string LegendLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MapZoomIn { get; set; }
		private string MapZoomIn_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MapZoomOut { get; set; }
		private string MapZoomOut_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string RangeSelectorButton { get; set; }
		private string RangeSelectorButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string RangeSelectorMaxInput { get; set; }
		private string RangeSelectorMaxInput_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string RangeSelectorMinInput { get; set; }
		private string RangeSelectorMinInput_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ResetZoomButton { get; set; }
		private string ResetZoomButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ScreenReaderRegionLabel { get; set; }
		private string ScreenReaderRegionLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// Lang configuration for different series types. For more dynamiccontrol over the series element descriptions, see[accessibility.seriesDescriptionFormatter](#accessibility.seriesDescriptionFormatter).
		/// </summary>
		public LangAccessibilitySeries Series { get; set; }
		private LangAccessibilitySeries Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// Descriptions of lesser known series types. The relevantdescription is added to the screen reader information regionwhen these series types are used.
		/// </summary>
		public LangAccessibilitySeriesTypeDescriptions SeriesTypeDescriptions { get; set; }
		private LangAccessibilitySeriesTypeDescriptions SeriesTypeDescriptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Label for the end of the chart. Announced by screen readers.
		/// </summary>
		public string SvgContainerEnd { get; set; }
		private string SvgContainerEnd_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string SvgContainerLabel { get; set; }
		private string SvgContainerLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// Title element text for the chart SVG element. Leave thisempty to disable adding the title element. Browsers will displaythis content when hovering over elements in the chart. Assistivetechnology may use this element to label the chart.
		/// </summary>
		public string SvgContainerTitle { get; set; }
		private string SvgContainerTitle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TableSummary { get; set; }
		private string TableSummary_DefaultValue { get; set; }
		 

		/// <summary>
		/// Thousands separator to use when formatting numbers for screenreaders. Note that many screen readers will not handle space as athousands separator, and will consider "11 700" as two numbers.Set to `null` to use the separator defined in[lang.thousandsSep](lang.thousandsSep).
		/// </summary>
		public string ThousandsSep { get; set; }
		private string ThousandsSep_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ViewAsDataTable { get; set; }
		private string ViewAsDataTable_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AnnounceNewData.IsDirty()) h.Add("announceNewData",AnnounceNewData.ToHashtable());
			if (Axis.IsDirty()) h.Add("axis",Axis.ToHashtable());
			if (ChartContainerLabel != ChartContainerLabel_DefaultValue) h.Add("chartContainerLabel",ChartContainerLabel);
			if (ChartHeading != ChartHeading_DefaultValue) h.Add("chartHeading",ChartHeading);
			if (ChartTypes.IsDirty()) h.Add("chartTypes",ChartTypes.ToHashtable());
			if (Credits != Credits_DefaultValue) h.Add("credits",Credits);
			if (DefaultChartTitle != DefaultChartTitle_DefaultValue) h.Add("defaultChartTitle",DefaultChartTitle);
			if (DrillUpButton != DrillUpButton_DefaultValue) h.Add("drillUpButton",DrillUpButton);
			if (Exporting.IsDirty()) h.Add("exporting",Exporting.ToHashtable());
			if (LegendItem != LegendItem_DefaultValue) h.Add("legendItem",LegendItem);
			if (LegendLabel != LegendLabel_DefaultValue) h.Add("legendLabel",LegendLabel);
			if (MapZoomIn != MapZoomIn_DefaultValue) h.Add("mapZoomIn",MapZoomIn);
			if (MapZoomOut != MapZoomOut_DefaultValue) h.Add("mapZoomOut",MapZoomOut);
			if (RangeSelectorButton != RangeSelectorButton_DefaultValue) h.Add("rangeSelectorButton",RangeSelectorButton);
			if (RangeSelectorMaxInput != RangeSelectorMaxInput_DefaultValue) h.Add("rangeSelectorMaxInput",RangeSelectorMaxInput);
			if (RangeSelectorMinInput != RangeSelectorMinInput_DefaultValue) h.Add("rangeSelectorMinInput",RangeSelectorMinInput);
			if (ResetZoomButton != ResetZoomButton_DefaultValue) h.Add("resetZoomButton",ResetZoomButton);
			if (ScreenReaderRegionLabel != ScreenReaderRegionLabel_DefaultValue) h.Add("screenReaderRegionLabel",ScreenReaderRegionLabel);
			if (Series.IsDirty()) h.Add("series",Series.ToHashtable());
			if (SeriesTypeDescriptions.IsDirty()) h.Add("seriesTypeDescriptions",SeriesTypeDescriptions.ToHashtable());
			if (SvgContainerEnd != SvgContainerEnd_DefaultValue) h.Add("svgContainerEnd",SvgContainerEnd);
			if (SvgContainerLabel != SvgContainerLabel_DefaultValue) h.Add("svgContainerLabel",SvgContainerLabel);
			if (SvgContainerTitle != SvgContainerTitle_DefaultValue) h.Add("svgContainerTitle",SvgContainerTitle);
			if (TableSummary != TableSummary_DefaultValue) h.Add("tableSummary",TableSummary);
			if (ThousandsSep != ThousandsSep_DefaultValue) h.Add("thousandsSep",ThousandsSep);
			if (ViewAsDataTable != ViewAsDataTable_DefaultValue) h.Add("viewAsDataTable",ViewAsDataTable);
			

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