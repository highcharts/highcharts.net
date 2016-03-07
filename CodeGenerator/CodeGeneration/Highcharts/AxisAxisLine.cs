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
	public partial class AxisAxisLine  : BaseObject
	{
		public AxisAxisLine()
		{
			Show = Show_DefaultValue = null;
			OnZero = OnZero_DefaultValue = null;
			LineStyle = LineStyle_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Specifies whether to show axisLine. Defaults to true, which is a prerequisite for the following properties.
		/// </summary>
		public boolean Show { get; set; }
		private boolean Show_DefaultValue { get; set; }
		 

		/// <summary>
		/// Locates to the coordinates whose vertical axis value is 0.
		/// </summary>
		public boolean OnZero { get; set; }
		private boolean OnZero_DefaultValue { get; set; }
		 

		/// <summary>
		/// controls the line style.
		/// </summary>
		public Object LineStyle { get; set; }
		private Object LineStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (OnZero != OnZero_DefaultValue) h.Add("onZero",OnZero);
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