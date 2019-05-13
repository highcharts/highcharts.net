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
	public partial class StockToolsGuiDefinitions  : BaseObject
	{
		public StockToolsGuiDefinitions()
		{
			Advanced = Advanced_DefaultValue = new StockToolsGuiDefinitionsAdvanced();
			CrookedLines = CrookedLines_DefaultValue = new StockToolsGuiDefinitionsCrookedLines();
			CurrentPriceIndicator = CurrentPriceIndicator_DefaultValue = new StockToolsGuiDefinitionsCurrentPriceIndicator();
			Flags = Flags_DefaultValue = new StockToolsGuiDefinitionsFlags();
			FullScreen = FullScreen_DefaultValue = new StockToolsGuiDefinitionsFullScreen();
			Indicators = Indicators_DefaultValue = new StockToolsGuiDefinitionsIndicators();
			Lines = Lines_DefaultValue = new StockToolsGuiDefinitionsLines();
			Measure = Measure_DefaultValue = new StockToolsGuiDefinitionsMeasure();
			SaveChart = SaveChart_DefaultValue = new StockToolsGuiDefinitionsSaveChart();
			Separator = Separator_DefaultValue = new StockToolsGuiDefinitionsSeparator();
			SimpleShapes = SimpleShapes_DefaultValue = new StockToolsGuiDefinitionsSimpleShapes();
			ToggleAnnotations = ToggleAnnotations_DefaultValue = new StockToolsGuiDefinitionsToggleAnnotations();
			TypeChange = TypeChange_DefaultValue = new StockToolsGuiDefinitionsTypeChange();
			VerticalLabels = VerticalLabels_DefaultValue = new StockToolsGuiDefinitionsVerticalLabels();
			ZoomChange = ZoomChange_DefaultValue = new StockToolsGuiDefinitionsZoomChange();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsAdvanced Advanced { get; set; }
		private StockToolsGuiDefinitionsAdvanced Advanced_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsCrookedLines CrookedLines { get; set; }
		private StockToolsGuiDefinitionsCrookedLines CrookedLines_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsCurrentPriceIndicator CurrentPriceIndicator { get; set; }
		private StockToolsGuiDefinitionsCurrentPriceIndicator CurrentPriceIndicator_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsFlags Flags { get; set; }
		private StockToolsGuiDefinitionsFlags Flags_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsFullScreen FullScreen { get; set; }
		private StockToolsGuiDefinitionsFullScreen FullScreen_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsIndicators Indicators { get; set; }
		private StockToolsGuiDefinitionsIndicators Indicators_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLines Lines { get; set; }
		private StockToolsGuiDefinitionsLines Lines_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsMeasure Measure { get; set; }
		private StockToolsGuiDefinitionsMeasure Measure_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSaveChart SaveChart { get; set; }
		private StockToolsGuiDefinitionsSaveChart SaveChart_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSeparator Separator { get; set; }
		private StockToolsGuiDefinitionsSeparator Separator_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSimpleShapes SimpleShapes { get; set; }
		private StockToolsGuiDefinitionsSimpleShapes SimpleShapes_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsToggleAnnotations ToggleAnnotations { get; set; }
		private StockToolsGuiDefinitionsToggleAnnotations ToggleAnnotations_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsTypeChange TypeChange { get; set; }
		private StockToolsGuiDefinitionsTypeChange TypeChange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsVerticalLabels VerticalLabels { get; set; }
		private StockToolsGuiDefinitionsVerticalLabels VerticalLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsZoomChange ZoomChange { get; set; }
		private StockToolsGuiDefinitionsZoomChange ZoomChange_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Advanced.IsDirty()) h.Add("advanced",Advanced.ToHashtable());
			if (CrookedLines.IsDirty()) h.Add("crookedLines",CrookedLines.ToHashtable());
			if (CurrentPriceIndicator.IsDirty()) h.Add("currentPriceIndicator",CurrentPriceIndicator.ToHashtable());
			if (Flags.IsDirty()) h.Add("flags",Flags.ToHashtable());
			if (FullScreen.IsDirty()) h.Add("fullScreen",FullScreen.ToHashtable());
			if (Indicators.IsDirty()) h.Add("indicators",Indicators.ToHashtable());
			if (Lines.IsDirty()) h.Add("lines",Lines.ToHashtable());
			if (Measure.IsDirty()) h.Add("measure",Measure.ToHashtable());
			if (SaveChart.IsDirty()) h.Add("saveChart",SaveChart.ToHashtable());
			if (Separator.IsDirty()) h.Add("separator",Separator.ToHashtable());
			if (SimpleShapes.IsDirty()) h.Add("simpleShapes",SimpleShapes.ToHashtable());
			if (ToggleAnnotations.IsDirty()) h.Add("toggleAnnotations",ToggleAnnotations.ToHashtable());
			if (TypeChange.IsDirty()) h.Add("typeChange",TypeChange.ToHashtable());
			if (VerticalLabels.IsDirty()) h.Add("verticalLabels",VerticalLabels.ToHashtable());
			if (ZoomChange.IsDirty()) h.Add("zoomChange",ZoomChange.ToHashtable());
			

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