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
	public partial class AnnotationsMeasure  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsMeasure()
		{
			ControlPointOptions = ControlPointOptions_DefaultValue = new AnnotationsMeasureControlPointOptions();
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsMeasureTypeOptions();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsMeasureControlPointOptions ControlPointOptions { get; set; }
		private AnnotationsMeasureControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsMeasureTypeOptions TypeOptions { get; set; }
		private AnnotationsMeasureTypeOptions TypeOptions_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ControlPointOptions.IsDirty(ref highstock)) h.Add("controlPointOptions",ControlPointOptions.ToHashtable(ref highstock));
			if (TypeOptions.IsDirty(ref highstock)) h.Add("typeOptions",TypeOptions.ToHashtable(ref highstock));
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}