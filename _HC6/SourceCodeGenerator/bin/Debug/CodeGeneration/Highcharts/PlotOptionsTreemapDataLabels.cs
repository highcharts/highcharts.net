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
	public partial class PlotOptionsTreemapDataLabels  : BaseObject
	{
		public PlotOptionsTreemapDataLabels()
		{
			Enabled = Enabled_DefaultValue = True;
			Defer = Defer_DefaultValue = False;
			VerticalAlign = VerticalAlign_DefaultValue = middle;
			Formatter = Formatter_DefaultValue = null;
			Inside = Inside_DefaultValue = True;
			Enabled = Enabled_DefaultValue = True;
			Defer = Defer_DefaultValue = False;
			VerticalAlign = VerticalAlign_DefaultValue = middle;
			Formatter = Formatter_DefaultValue = "";
			Inside = Inside_DefaultValue = True;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDataLabelsEnabled Enabled { get; set; }
		private PlotOptionsTreemapDataLabelsEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDataLabelsDefer Defer { get; set; }
		private PlotOptionsTreemapDataLabelsDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDataLabelsVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsTreemapDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDataLabelsFormatter Formatter { get; set; }
		private PlotOptionsTreemapDataLabelsFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDataLabelsInside Inside { get; set; }
		private PlotOptionsTreemapDataLabelsInside Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDataLabelsEnabled Enabled { get; set; }
		private PlotOptionsTreemapDataLabelsEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDataLabelsDefer Defer { get; set; }
		private PlotOptionsTreemapDataLabelsDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDataLabelsVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsTreemapDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDataLabelsFormatter Formatter { get; set; }
		private PlotOptionsTreemapDataLabelsFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapDataLabelsInside Inside { get; set; }
		private PlotOptionsTreemapDataLabelsInside Inside_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			

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