using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PyramidSeriesDragDropGuideBox  : BaseObject
	{
		public PyramidSeriesDragDropGuideBox()
		{
			Default = Default_DefaultValue = new PyramidSeriesDragDropGuideBoxDefault();
			
		}	
		

		/// <summary>
		/// Style options for the guide box default state.
		/// </summary>
		public PyramidSeriesDragDropGuideBoxDefault Default { get; set; }
		private PyramidSeriesDragDropGuideBoxDefault Default_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Default.IsDirty()) h.Add("default",Default.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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