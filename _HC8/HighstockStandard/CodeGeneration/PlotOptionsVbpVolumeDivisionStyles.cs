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
	public partial class PlotOptionsVbpVolumeDivisionStyles  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVbpVolumeDivisionStyles()
		{
			NegativeColor = NegativeColor_DefaultValue = "rgba(244, 91, 91, 0.8)";
			PositiveColor = PositiveColor_DefaultValue = "rgba(144, 237, 125, 0.8)";
			
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
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (PositiveColor != PositiveColor_DefaultValue) h.Add("positiveColor",PositiveColor);
			

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