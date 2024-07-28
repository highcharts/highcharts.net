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
		Hashtable h = new Hashtable();

		public StockToolsGuiDefinitions()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsAdvanced Advanced { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsCrookedLines CrookedLines { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsCurrentPriceIndicator CurrentPriceIndicator { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsFlags Flags { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsFullScreen FullScreen { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsIndicators Indicators { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLines Lines { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsMeasure Measure { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSaveChart SaveChart { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSeparator Separator { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsSimpleShapes SimpleShapes { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsToggleAnnotations ToggleAnnotations { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsTypeChange TypeChange { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsVerticalLabels VerticalLabels { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsZoomChange ZoomChange { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Advanced != null) h.Add("advanced",Advanced.ToHashtable(highstock));
			if (CrookedLines != null) h.Add("crookedLines",CrookedLines.ToHashtable(highstock));
			if (CurrentPriceIndicator != null) h.Add("currentPriceIndicator",CurrentPriceIndicator.ToHashtable(highstock));
			if (Flags != null) h.Add("flags",Flags.ToHashtable(highstock));
			if (FullScreen != null) h.Add("fullScreen",FullScreen.ToHashtable(highstock));
			if (Indicators != null) h.Add("indicators",Indicators.ToHashtable(highstock));
			if (Lines != null) h.Add("lines",Lines.ToHashtable(highstock));
			if (Measure != null) h.Add("measure",Measure.ToHashtable(highstock));
			if (SaveChart != null) h.Add("saveChart",SaveChart.ToHashtable(highstock));
			if (Separator != null) h.Add("separator",Separator.ToHashtable(highstock));
			if (SimpleShapes != null) h.Add("simpleShapes",SimpleShapes.ToHashtable(highstock));
			if (ToggleAnnotations != null) h.Add("toggleAnnotations",ToggleAnnotations.ToHashtable(highstock));
			if (TypeChange != null) h.Add("typeChange",TypeChange.ToHashtable(highstock));
			if (VerticalLabels != null) h.Add("verticalLabels",VerticalLabels.ToHashtable(highstock));
			if (ZoomChange != null) h.Add("zoomChange",ZoomChange.ToHashtable(highstock));
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