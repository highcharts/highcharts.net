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
		public WordcloudSeriesStyle()
		{
			FontFamily = FontFamily_DefaultValue = "sans-serif";
			FontWeight = FontWeight_DefaultValue = "null";
			FontWeightNumber = FontWeightNumber_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string FontFamily { get; set; }
		private string FontFamily_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string FontWeight { get; set; }
		private string FontWeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? FontWeightNumber { get; set; }
		private double? FontWeightNumber_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (FontFamily != FontFamily_DefaultValue) h.Add("fontFamily",FontFamily);
			if (FontWeight != FontWeight_DefaultValue) h.Add("fontWeight",FontWeight);
			if (FontWeightNumber != FontWeightNumber_DefaultValue) h.Add("fontWeight",FontWeightNumber);
			

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