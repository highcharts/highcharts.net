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
	public partial class Responsive  : BaseObject
	{
		public Responsive()
		{
			Rules = Rules_DefaultValue = new ResponsiveRules();
			
		}	
		

		/// <summary>
		/// A set of rules for responsive settings. The rules are executed from the top down.
		/// </summary>
		public ResponsiveRules Rules { get; set; }
		private ResponsiveRules Rules_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Rules.IsDirty()) h.Add("rules",Rules.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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