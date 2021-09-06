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
	public partial class AnnotationsFibonacci  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsFibonacci()
		{
			LabelOptions = LabelOptions_DefaultValue = new AnnotationsFibonacciLabelOptions();
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsFibonacciTypeOptions();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsFibonacciLabelOptions LabelOptions { get; set; }
		private AnnotationsFibonacciLabelOptions LabelOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsFibonacciTypeOptions TypeOptions { get; set; }
		private AnnotationsFibonacciTypeOptions TypeOptions_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (LabelOptions.IsDirty(ref highstock)) h.Add("labelOptions",LabelOptions.ToHashtable(ref highstock));
			if (TypeOptions.IsDirty(ref highstock)) h.Add("typeOptions",TypeOptions.ToHashtable(ref highstock));
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}