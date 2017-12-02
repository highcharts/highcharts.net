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
	public partial class HistogramSeriesSunburstLevelsColorVariation  : BaseObject
	{
		public HistogramSeriesSunburstLevelsColorVariation()
		{
			Key = Key_DefaultValue = "";
			To = To_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The key of a color variation. Currently supports `brightness` only.
		/// </summary>
		public string Key { get; set; }
		private string Key_DefaultValue { get; set; }
		 

		/// <summary>
		/// The ending value of a color variation. The last sibling will receive thisvalue.
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Key != Key_DefaultValue) h.Add("key",Key);
			if (To != To_DefaultValue) h.Add("to",To);
			

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