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
	public partial class ResponsiveRulesCondition  : BaseObject
	{
		public ResponsiveRulesCondition()
		{
			Callback = Callback_DefaultValue = "";
			MaxHeight = MaxHeight_DefaultValue = null;
			MaxWidth = MaxWidth_DefaultValue = null;
			MinHeight = MinHeight_DefaultValue = 0;
			MinWidth = MinWidth_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// A callback function to gain complete control on when the responsiverule applies. Return `true` if it applies. This opens for checkingagainst other metrics than the chart size, or example the documentsize or other elements.
		/// </summary>
		public string Callback { get; set; }
		private string Callback_DefaultValue { get; set; }
		 

		/// <summary>
		/// The responsive rule applies if the chart height is less than this.
		/// </summary>
		public double? MaxHeight { get; set; }
		private double? MaxHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The responsive rule applies if the chart width is less than this.
		/// </summary>
		public double? MaxWidth { get; set; }
		private double? MaxWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The responsive rule applies if the chart height is greater than this.
		/// </summary>
		public double? MinHeight { get; set; }
		private double? MinHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The responsive rule applies if the chart width is greater than this.
		/// </summary>
		public double? MinWidth { get; set; }
		private double? MinWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Callback != Callback_DefaultValue) h.Add("callback",Callback);
			if (MaxHeight != MaxHeight_DefaultValue) h.Add("maxHeight",MaxHeight);
			if (MaxWidth != MaxWidth_DefaultValue) h.Add("maxWidth",MaxWidth);
			if (MinHeight != MinHeight_DefaultValue) h.Add("minHeight",MinHeight);
			if (MinWidth != MinWidth_DefaultValue) h.Add("minWidth",MinWidth);
			

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