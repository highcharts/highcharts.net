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
	public partial class LangAccessibility  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibility()
		{
			AnnounceNewData = AnnounceNewData_DefaultValue = new LangAccessibilityAnnounceNewData();
			Axis = Axis_DefaultValue = new LangAccessibilityAxis();
			ChartContainerLabel = ChartContainerLabel_DefaultValue = "{title}. Highcharts interactive chart.";
			ChartTypes = ChartTypes_DefaultValue = new LangAccessibilityChartTypes();
			Credits = Credits_DefaultValue = "Chart credits: {creditsStr}";
			DefaultChartTitle = DefaultChartTitle_DefaultValue = "Chart";
			DrillUpButton = DrillUpButton_DefaultValue = "{buttonText}";
			Exporting = Exporting_DefaultValue = new LangAccessibilityExporting();
			GraphicContainerLabel = GraphicContainerLabel_DefaultValue = "";
			Legend = Legend_DefaultValue = new LangAccessibilityLegend();
			RangeSelector = RangeSelector_DefaultValue = new LangAccessibilityRangeSelector();
			ScreenReaderSection = ScreenReaderSection_DefaultValue = new LangAccessibilityScreenReaderSection();
			Series = Series_DefaultValue = new LangAccessibilitySeries();
			SeriesTypeDescriptions = SeriesTypeDescriptions_DefaultValue = new LangAccessibilitySeriesTypeDescriptions();
			Sonification = Sonification_DefaultValue = new LangAccessibilitySonification();
			SvgContainerLabel = SvgContainerLabel_DefaultValue = "Interactive chart";
			SvgContainerTitle = SvgContainerTitle_DefaultValue = "";
			Table = Table_DefaultValue = new LangAccessibilityTable();
			ThousandsSep = ThousandsSep_DefaultValue = ",";
			Zoom = Zoom_DefaultValue = new LangAccessibilityZoom();
			
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
		/// Set a label on the container wrapping the SVG.
		/// </summary>
		public string GraphicContainerLabel { get; set; }
		private string GraphicContainerLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// Language options for accessibility of the legend.
		/// </summary>
		public LangAccessibilityLegend Legend { get; set; }
		private LangAccessibilityLegend Legend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Range selector language options for accessibility.
		/// </summary>
		public LangAccessibilityRangeSelector RangeSelector { get; set; }
		private LangAccessibilityRangeSelector RangeSelector_DefaultValue { get; set; }
		 

		/// <summary>
		/// Language options for the screen reader information sections addedbefore and after the charts.
		/// </summary>
		public LangAccessibilityScreenReaderSection ScreenReaderSection { get; set; }
		private LangAccessibilityScreenReaderSection ScreenReaderSection_DefaultValue { get; set; }
		 

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
		/// Language options for sonification.
		/// </summary>
		public LangAccessibilitySonification Sonification { get; set; }
		private LangAccessibilitySonification Sonification_DefaultValue { get; set; }
		 

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
		/// Accessibility language options for the data table.
		/// </summary>
		public LangAccessibilityTable Table { get; set; }
		private LangAccessibilityTable Table_DefaultValue { get; set; }
		 

		/// <summary>
		/// Thousands separator to use when formatting numbers for screenreaders. Note that many screen readers will not handle space as athousands separator, and will consider "11 700" as two numbers.Set to `null` to use the separator defined in[lang.thousandsSep](lang.thousandsSep).
		/// </summary>
		public string ThousandsSep { get; set; }
		private string ThousandsSep_DefaultValue { get; set; }
		 

		/// <summary>
		/// Chart and map zoom accessibility language options.
		/// </summary>
		public LangAccessibilityZoom Zoom { get; set; }
		private LangAccessibilityZoom Zoom_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (AnnounceNewData.IsDirty(highstock)) h.Add("announceNewData",AnnounceNewData.ToHashtable(highstock));
			if (Axis.IsDirty(highstock)) h.Add("axis",Axis.ToHashtable(highstock));
			if (ChartContainerLabel != ChartContainerLabel_DefaultValue) h.Add("chartContainerLabel",ChartContainerLabel);
			if (ChartTypes.IsDirty(highstock)) h.Add("chartTypes",ChartTypes.ToHashtable(highstock));
			if (Credits != Credits_DefaultValue) h.Add("credits",Credits);
			if (DefaultChartTitle != DefaultChartTitle_DefaultValue) h.Add("defaultChartTitle",DefaultChartTitle);
			if (DrillUpButton != DrillUpButton_DefaultValue) h.Add("drillUpButton",DrillUpButton);
			if (Exporting.IsDirty(highstock)) h.Add("exporting",Exporting.ToHashtable(highstock));
			if (GraphicContainerLabel != GraphicContainerLabel_DefaultValue) h.Add("graphicContainerLabel",GraphicContainerLabel);
			if (Legend.IsDirty(highstock)) h.Add("legend",Legend.ToHashtable(highstock));
			if (RangeSelector.IsDirty(highstock)) h.Add("rangeSelector",RangeSelector.ToHashtable(highstock));
			if (ScreenReaderSection.IsDirty(highstock)) h.Add("screenReaderSection",ScreenReaderSection.ToHashtable(highstock));
			if (Series.IsDirty(highstock)) h.Add("series",Series.ToHashtable(highstock));
			if (SeriesTypeDescriptions.IsDirty(highstock)) h.Add("seriesTypeDescriptions",SeriesTypeDescriptions.ToHashtable(highstock));
			if (Sonification.IsDirty(highstock)) h.Add("sonification",Sonification.ToHashtable(highstock));
			if (SvgContainerLabel != SvgContainerLabel_DefaultValue) h.Add("svgContainerLabel",SvgContainerLabel);
			if (SvgContainerTitle != SvgContainerTitle_DefaultValue) h.Add("svgContainerTitle",SvgContainerTitle);
			if (Table.IsDirty(highstock)) h.Add("table",Table.ToHashtable(highstock));
			if (ThousandsSep != ThousandsSep_DefaultValue) h.Add("thousandsSep",ThousandsSep);
			if (Zoom.IsDirty(highstock)) h.Add("zoom",Zoom.ToHashtable(highstock));
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}