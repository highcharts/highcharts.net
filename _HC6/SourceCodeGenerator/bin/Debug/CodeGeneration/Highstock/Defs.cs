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
	public partial class Defs  : BaseObject
	{
		public Defs()
		{
			Markers = Markers_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Options for configuring markers for annotations.An example of the arrow marker:<pre>{  arrow: {    id: 'arrow',    refY: 5,    refX: 5,    markerWidth: 10,    markerHeight: 10,    children: [{      tagName: 'path',      attrs: {        d: 'M 0 0 L 10 5 L 0 10 Z',        strokeWidth: 0      }    }]  }}</pre>
		/// </summary>
		public Object Markers { get; set; }
		private Object Markers_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Markers != Markers_DefaultValue) h.Add("markers",Markers);
			

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