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
	public partial class LangAccessibilitySeriesTypeDescriptions  : BaseObject
	{
		public LangAccessibilitySeriesTypeDescriptions()
		{
			Boxplot = Boxplot_DefaultValue = "";
			Arearange = Arearange_DefaultValue = "";
			Areasplinerange = Areasplinerange_DefaultValue = "";
			Bubble = Bubble_DefaultValue = "";
			Columnrange = Columnrange_DefaultValue = "";
			Errorbar = Errorbar_DefaultValue = "";
			Funnel = Funnel_DefaultValue = "";
			Pyramid = Pyramid_DefaultValue = "";
			Waterfall = Waterfall_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public LangAccessibilitySeriesTypeDescriptionsBoxplot Boxplot { get; set; }
		private LangAccessibilitySeriesTypeDescriptionsBoxplot Boxplot_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LangAccessibilitySeriesTypeDescriptionsArearange Arearange { get; set; }
		private LangAccessibilitySeriesTypeDescriptionsArearange Arearange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LangAccessibilitySeriesTypeDescriptionsAreasplinerange Areasplinerange { get; set; }
		private LangAccessibilitySeriesTypeDescriptionsAreasplinerange Areasplinerange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LangAccessibilitySeriesTypeDescriptionsBubble Bubble { get; set; }
		private LangAccessibilitySeriesTypeDescriptionsBubble Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LangAccessibilitySeriesTypeDescriptionsColumnrange Columnrange { get; set; }
		private LangAccessibilitySeriesTypeDescriptionsColumnrange Columnrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LangAccessibilitySeriesTypeDescriptionsErrorbar Errorbar { get; set; }
		private LangAccessibilitySeriesTypeDescriptionsErrorbar Errorbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LangAccessibilitySeriesTypeDescriptionsFunnel Funnel { get; set; }
		private LangAccessibilitySeriesTypeDescriptionsFunnel Funnel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LangAccessibilitySeriesTypeDescriptionsPyramid Pyramid { get; set; }
		private LangAccessibilitySeriesTypeDescriptionsPyramid Pyramid_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LangAccessibilitySeriesTypeDescriptionsWaterfall Waterfall { get; set; }
		private LangAccessibilitySeriesTypeDescriptionsWaterfall Waterfall_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Boxplot != Boxplot_DefaultValue) h.Add("boxplot",Boxplot);
			if (Arearange != Arearange_DefaultValue) h.Add("arearange",Arearange);
			if (Areasplinerange != Areasplinerange_DefaultValue) h.Add("areasplinerange",Areasplinerange);
			if (Bubble != Bubble_DefaultValue) h.Add("bubble",Bubble);
			if (Columnrange != Columnrange_DefaultValue) h.Add("columnrange",Columnrange);
			if (Errorbar != Errorbar_DefaultValue) h.Add("errorbar",Errorbar);
			if (Funnel != Funnel_DefaultValue) h.Add("funnel",Funnel);
			if (Pyramid != Pyramid_DefaultValue) h.Add("pyramid",Pyramid);
			if (Waterfall != Waterfall_DefaultValue) h.Add("waterfall",Waterfall);
			

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