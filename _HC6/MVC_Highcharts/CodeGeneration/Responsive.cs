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
	public partial class Responsive  : BaseObject
	{
		public Responsive()
		{
			Rules = Rules_DefaultValue = new List<ResponsiveRules>();
			
		}	
		

		/// <summary>
		/// A set of rules for responsive settings. The rules are executed fromthe top down.
		/// </summary>
		public List<ResponsiveRules> Rules { get; set; }
		private List<ResponsiveRules> Rules_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Rules != Rules_DefaultValue) h.Add("rules", HashifyList(Rules));
			

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