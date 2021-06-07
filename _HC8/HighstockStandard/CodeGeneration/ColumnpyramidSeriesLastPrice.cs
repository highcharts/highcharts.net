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
	public partial class ColumnpyramidSeriesLastPrice  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColumnpyramidSeriesLastPrice()
		{
			Color = Color_DefaultValue = "";
			Enabled = Enabled_DefaultValue = false;
			Label = Label_DefaultValue = new ColumnpyramidSeriesLastPriceLabel();
			
		}	
		

		/// <summary>
		/// The color of the line of last price.By default, the line has the same color as the series.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the indicator.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColumnpyramidSeriesLastPriceLabel Label { get; set; }
		private ColumnpyramidSeriesLastPriceLabel Label_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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