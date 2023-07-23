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
	public partial class VbpSeriesVolumeDivisionStyles  : BaseObject
	{
		Hashtable h = new Hashtable();

		public VbpSeriesVolumeDivisionStyles()
		{
			NegativeColor = NegativeColor_DefaultValue = "rgba(244, 91, 91, 0.8)";
			PositiveColor = PositiveColor_DefaultValue = "rgba(144, 237, 125, 0.8)";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Color of negative volume bars.
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of positive volume bars.
		/// </summary>
		public string PositiveColor { get; set; }
		private string PositiveColor_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (PositiveColor != PositiveColor_DefaultValue) h.Add("positiveColor",PositiveColor);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}