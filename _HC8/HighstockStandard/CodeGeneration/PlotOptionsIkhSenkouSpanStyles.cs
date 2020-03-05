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
	public partial class PlotOptionsIkhSenkouSpanStyles  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsIkhSenkouSpanStyles()
		{
			Fill = Fill_DefaultValue = "rgba(255, 0, 0, 0.5)";
			
		}	
		

		/// <summary>
		/// Color of the area between Senkou Span A and B.
		/// </summary>
		public string Fill { get; set; }
		private string Fill_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			

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