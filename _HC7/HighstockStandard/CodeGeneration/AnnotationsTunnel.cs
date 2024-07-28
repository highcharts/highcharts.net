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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsTunnelControlPointOptions ControlPointOptions { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsTunnelTypeOptions TypeOptions { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ControlPointOptions != null) h.Add("controlPointOptions",ControlPointOptions.ToHashtable(highstock));
			if (TypeOptions != null) h.Add("typeOptions",TypeOptions.ToHashtable(highstock));
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}