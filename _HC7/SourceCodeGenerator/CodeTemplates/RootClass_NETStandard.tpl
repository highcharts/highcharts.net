using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace {HighTemplate.Namespace}
{
	public partial class {HighTemplate.Classname}
	{
		public {HighTemplate.ClassName}()
		{
			{HighTemplate.ConstrutorInitializers}
		}	
		{HighTemplate.Properties} 

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			{HighTemplate.HashtableInit}

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}