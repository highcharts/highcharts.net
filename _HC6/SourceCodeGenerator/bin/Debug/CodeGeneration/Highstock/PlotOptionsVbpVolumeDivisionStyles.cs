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
	public partial class PlotOptionsVbpVolumeDivisionStyles  : BaseObject
	{
		public PlotOptionsVbpVolumeDivisionStyles()
		{
			PositiveColor = PositiveColor_DefaultValue = "rgba(144, 237, 125, 0.8)";
			NegativeColor = NegativeColor_DefaultValue = "rgba(244, 91, 91, 0.8)";
			
		}	
		

		/// <summary>
		/// Color of positive volume bars.
		/// </summary>
		public string PositiveColor { get; set; }
		private string PositiveColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of negative volume bars.
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (PositiveColor != PositiveColor_DefaultValue) h.Add("positiveColor",PositiveColor);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			

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