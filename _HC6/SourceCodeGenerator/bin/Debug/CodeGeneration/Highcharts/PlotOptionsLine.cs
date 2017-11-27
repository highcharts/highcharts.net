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
	public partial class PlotOptionsLine  : BaseObject
	{
		public PlotOptionsLine()
		{
			Linecap = Linecap_DefaultValue = "round";
			Linecap = Linecap_DefaultValue = "round";
			
		}	
		

		/// <summary>
		/// The SVG value used for the `stroke-linecap` and `stroke-linejoin`of a line graph. Round means that lines are rounded in the ends andbends.
		/// </summary>
		public string Linecap { get; set; }
		private string Linecap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The SVG value used for the `stroke-linecap` and `stroke-linejoin`of a line graph. Round means that lines are rounded in the ends andbends.
		/// </summary>
		public string Linecap { get; set; }
		private string Linecap_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Linecap != Linecap_DefaultValue) h.Add("linecap",Linecap);
			if (Linecap != Linecap_DefaultValue) h.Add("linecap",Linecap);
			

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