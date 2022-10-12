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
	public partial class AnnotationsTunnel  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsTunnel()
		{
			ControlPointOptions = ControlPointOptions_DefaultValue = new AnnotationsTunnelControlPointOptions();
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsTunnelTypeOptions();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsTunnelControlPointOptions ControlPointOptions { get; set; }
		private AnnotationsTunnelControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsTunnelTypeOptions TypeOptions { get; set; }
		private AnnotationsTunnelTypeOptions TypeOptions_DefaultValue { get; set; }
		  

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