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
	public partial class AxisSplitLine  : BaseObject
	{
		public AxisSplitLine()
		{
			Show = Show_DefaultValue = null;
			OnGap = OnGap_DefaultValue = null;
			LineStyle = LineStyle_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Specifies whether to show splitLine. Defaults to true, which is a prerequisite for the following properties.
		/// </summary>
		public boolean Show { get; set; }
		private boolean Show_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether the splitLine will be positioned at regular intervals. Equal to boundaryGap by default.
		/// </summary>
		public boolean OnGap { get; set; }
		private boolean OnGap_DefaultValue { get; set; }
		 

		/// <summary>
		/// controls the line style .
		/// </summary>
		public Object LineStyle { get; set; }
		private Object LineStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (OnGap != OnGap_DefaultValue) h.Add("onGap",OnGap);
			if (LineStyle != LineStyle_DefaultValue) h.Add("lineStyle",LineStyle);
			

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