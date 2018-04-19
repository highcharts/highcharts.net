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
	public partial class LangAccessibility  : BaseObject
	{
		public LangAccessibility()
		{
			ScreenReaderRegionLabel = ScreenReaderRegionLabel_DefaultValue = "Chart screen reader information.";
			NavigationHint = NavigationHint_DefaultValue = "Use regions/landmarks to skip ahead to chart {#plural(numSeries, and navigate between data series,)}";
			DefaultChartTitle = DefaultChartTitle_DefaultValue = "Chart";
			LongDescriptionHeading = LongDescriptionHeading_DefaultValue = "Long description.";
			NoDescription = NoDescription_DefaultValue = "No description available.";
			StructureHeading = StructureHeading_DefaultValue = "Structure.";
			ViewAsDataTable = ViewAsDataTable_DefaultValue = "View as data table.";
			ChartHeading = ChartHeading_DefaultValue = "Chart graphic.";
			ChartContainerLabel = ChartContainerLabel_DefaultValue = "Interactive chart. {title}. Use up and down arrows to navigate with most screen readers.";
			RangeSelectorMinInput = RangeSelectorMinInput_DefaultValue = "Select start date.";
			RangeSelectorMaxInput = RangeSelectorMaxInput_DefaultValue = "Select end date.";
			TableSummary = TableSummary_DefaultValue = "Table representation of chart.";
			MapZoomIn = MapZoomIn_DefaultValue = "Zoom chart";
			MapZoomOut = MapZoomOut_DefaultValue = "Zoom out chart";
			RangeSelectorButton = RangeSelectorButton_DefaultValue = "Select range {buttonText}";
			LegendItem = LegendItem_DefaultValue = "Toggle visibility of series {itemName}";
			SeriesTypeDescriptions = SeriesTypeDescriptions_DefaultValue = new LangAccessibilitySeriesTypeDescriptions();
			ChartTypes = ChartTypes_DefaultValue = new LangAccessibilityChartTypes();
			Axis = Axis_DefaultValue = new LangAccessibilityAxis();
			Exporting = Exporting_DefaultValue = new LangAccessibilityExporting();
			Series = Series_DefaultValue = new List<Series>();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string ScreenReaderRegionLabel { get; set; }
		private string ScreenReaderRegionLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NavigationHint { get; set; }
		private string NavigationHint_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string DefaultChartTitle { get; set; }
		private string DefaultChartTitle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string LongDescriptionHeading { get; set; }
		private string LongDescriptionHeading_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NoDescription { get; set; }
		private string NoDescription_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string StructureHeading { get; set; }
		private string StructureHeading_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ViewAsDataTable { get; set; }
		private string ViewAsDataTable_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ChartHeading { get; set; }
		private string ChartHeading_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ChartContainerLabel { get; set; }
		private string ChartContainerLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string RangeSelectorMinInput { get; set; }
		private string RangeSelectorMinInput_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string RangeSelectorMaxInput { get; set; }
		private string RangeSelectorMaxInput_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TableSummary { get; set; }
		private string TableSummary_DefaultValue { get; set; }
		 

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
		public string LegendItem { get; set; }
		private string LegendItem_DefaultValue { get; set; }
		 

		/// <summary>
		/// Descriptions of lesser known series types. The relevantdescription is added to the screen reader information regionwhen these series types are used.
		/// </summary>
		public LangAccessibilitySeriesTypeDescriptions SeriesTypeDescriptions { get; set; }
		private LangAccessibilitySeriesTypeDescriptions SeriesTypeDescriptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Chart type description strings. This is added to the chart information region.If there is only a single series type used in the chart, we usethe format string for the series type, or default if missing.There is one format string for cases where there is only a singleseries in the chart, and one for multiple series of the sametype.
		/// </summary>
		public LangAccessibilityChartTypes ChartTypes { get; set; }
		private LangAccessibilityChartTypes ChartTypes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Axis description format strings.
		/// </summary>
		public LangAccessibilityAxis Axis { get; set; }
		private LangAccessibilityAxis Axis_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exporting menu format strings for accessibility module.
		/// </summary>
		public LangAccessibilityExporting Exporting { get; set; }
		private LangAccessibilityExporting Exporting_DefaultValue { get; set; }
		 

		/// <summary>
		/// Lang configuration for different series types. For more dynamiccontrol over the series element descriptions, see[accessibility.seriesDescriptionFormatter](accessibility.seriesDescriptionFormatter).
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ScreenReaderRegionLabel != ScreenReaderRegionLabel_DefaultValue) h.Add("screenReaderRegionLabel",ScreenReaderRegionLabel);
			if (NavigationHint != NavigationHint_DefaultValue) h.Add("navigationHint",NavigationHint);
			if (DefaultChartTitle != DefaultChartTitle_DefaultValue) h.Add("defaultChartTitle",DefaultChartTitle);
			if (LongDescriptionHeading != LongDescriptionHeading_DefaultValue) h.Add("longDescriptionHeading",LongDescriptionHeading);
			if (NoDescription != NoDescription_DefaultValue) h.Add("noDescription",NoDescription);
			if (StructureHeading != StructureHeading_DefaultValue) h.Add("structureHeading",StructureHeading);
			if (ViewAsDataTable != ViewAsDataTable_DefaultValue) h.Add("viewAsDataTable",ViewAsDataTable);
			if (ChartHeading != ChartHeading_DefaultValue) h.Add("chartHeading",ChartHeading);
			if (ChartContainerLabel != ChartContainerLabel_DefaultValue) h.Add("chartContainerLabel",ChartContainerLabel);
			if (RangeSelectorMinInput != RangeSelectorMinInput_DefaultValue) h.Add("rangeSelectorMinInput",RangeSelectorMinInput);
			if (RangeSelectorMaxInput != RangeSelectorMaxInput_DefaultValue) h.Add("rangeSelectorMaxInput",RangeSelectorMaxInput);
			if (TableSummary != TableSummary_DefaultValue) h.Add("tableSummary",TableSummary);
			if (MapZoomIn != MapZoomIn_DefaultValue) h.Add("mapZoomIn",MapZoomIn);
			if (MapZoomOut != MapZoomOut_DefaultValue) h.Add("mapZoomOut",MapZoomOut);
			if (RangeSelectorButton != RangeSelectorButton_DefaultValue) h.Add("rangeSelectorButton",RangeSelectorButton);
			if (LegendItem != LegendItem_DefaultValue) h.Add("legendItem",LegendItem);
			if (SeriesTypeDescriptions.IsDirty()) h.Add("seriesTypeDescriptions",SeriesTypeDescriptions.ToHashtable());
			if (ChartTypes.IsDirty()) h.Add("chartTypes",ChartTypes.ToHashtable());
			if (Axis.IsDirty()) h.Add("axis",Axis.ToHashtable());
			if (Exporting.IsDirty()) h.Add("exporting",Exporting.ToHashtable());
			if (Series != Series_DefaultValue) h.Add("series",Series);
			

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