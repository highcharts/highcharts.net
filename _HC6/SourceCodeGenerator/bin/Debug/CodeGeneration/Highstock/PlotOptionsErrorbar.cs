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
	public partial class PlotOptionsErrorbar  : BaseObject
	{
		public PlotOptionsErrorbar()
		{
			Color = Color_DefaultValue = "#000000";
			Grouping = Grouping_DefaultValue = false;
			LinkedTo = LinkedTo_DefaultValue = ":previous";
			Tooltip = Tooltip_DefaultValue = new PlotOptionsErrorbarTooltip();
			WhiskerWidth = WhiskerWidth_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The main color of the bars. This can be overridden by [stemColor](#plotOptions.errorbar.stemColor) and [whiskerColor](#plotOptions.errorbar.whiskerColor)individually.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Grouping { get; set; }
		private bool? Grouping_DefaultValue { get; set; }
		 

		/// <summary>
		/// The parent series of the error bar. The default value links it tothe previous series. Otherwise, use the id of the parent series.
		/// </summary>
		public string LinkedTo { get; set; }
		private string LinkedTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsErrorbarTooltip Tooltip { get; set; }
		private PlotOptionsErrorbarTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line width of the whiskers, the horizontal lines marking lowand high values. When `null`, the general [lineWidth](#plotOptions.errorbar.lineWidth) applies.
		/// </summary>
		public double? WhiskerWidth { get; set; }
		private double? WhiskerWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Grouping != Grouping_DefaultValue) h.Add("grouping",Grouping);
			if (LinkedTo != LinkedTo_DefaultValue) h.Add("linkedTo",LinkedTo);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (WhiskerWidth != WhiskerWidth_DefaultValue) h.Add("whiskerWidth",WhiskerWidth);
			

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