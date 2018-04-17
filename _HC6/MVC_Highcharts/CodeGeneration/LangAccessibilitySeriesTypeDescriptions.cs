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
		public string Boxplot { get; set; }
		private string Boxplot_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Arearange { get; set; }
		private string Arearange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Areasplinerange { get; set; }
		private string Areasplinerange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Bubble { get; set; }
		private string Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Columnrange { get; set; }
		private string Columnrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Errorbar { get; set; }
		private string Errorbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Funnel { get; set; }
		private string Funnel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Pyramid { get; set; }
		private string Pyramid_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Waterfall { get; set; }
		private string Waterfall_DefaultValue { get; set; }
		  

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