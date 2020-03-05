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
	public partial class AnnotationsPitchfork  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsPitchfork()
		{
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsPitchforkTypeOptions();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsPitchforkTypeOptions TypeOptions { get; set; }
		private AnnotationsPitchforkTypeOptions TypeOptions_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (TypeOptions.IsDirty()) h.Add("typeOptions",TypeOptions.ToHashtable());
			

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