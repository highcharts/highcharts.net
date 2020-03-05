using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class WordcloudSeriesStyle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public WordcloudSeriesStyle()
		{
			FontFamily = FontFamily_DefaultValue = "sans-serif";
			FontWeight = FontWeight_DefaultValue = 900;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string FontFamily { get; set; }
		private string FontFamily_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? FontWeight { get; set; }
		private double? FontWeight_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (FontFamily != FontFamily_DefaultValue) h.Add("fontFamily",FontFamily);
			if (FontWeight != FontWeight_DefaultValue) h.Add("fontWeight",FontWeight);
			

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