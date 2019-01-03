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
	public partial class PlotOptionsSmaTooltip  : BaseObject
	{
		public PlotOptionsSmaTooltip()
		{
			ValueDecimals = ValueDecimals_DefaultValue = 4;
			
		}	
		

		/// <summary>
		/// Number of decimals in indicator series.
		/// </summary>
		public double? ValueDecimals { get; set; }
		private double? ValueDecimals_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ValueDecimals != ValueDecimals_DefaultValue) h.Add("valueDecimals",ValueDecimals);
			

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