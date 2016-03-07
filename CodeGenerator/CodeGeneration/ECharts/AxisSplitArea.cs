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
	public partial class AxisSplitArea  : BaseObject
	{
		public AxisSplitArea()
		{
			Show = Show_DefaultValue = null;
			OnGap = OnGap_DefaultValue = null;
			AreaStyle = AreaStyle_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// universal
		/// </summary>
		public boolean Show { get; set; }
		private boolean Show_DefaultValue { get; set; }
		 

		/// <summary>
		/// category axis
		/// </summary>
		public boolean OnGap { get; set; }
		private boolean OnGap_DefaultValue { get; set; }
		 

		/// <summary>
		/// universal
		/// </summary>
		public Object AreaStyle { get; set; }
		private Object AreaStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (OnGap != OnGap_DefaultValue) h.Add("onGap",OnGap);
			if (AreaStyle != AreaStyle_DefaultValue) h.Add("areaStyle",AreaStyle);
			

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