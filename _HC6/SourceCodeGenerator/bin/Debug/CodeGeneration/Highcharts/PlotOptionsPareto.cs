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
	public partial class PlotOptionsPareto  : BaseObject
	{
		public PlotOptionsPareto()
		{
			ZIndex = ZIndex_DefaultValue = 3;
			ZIndex = ZIndex_DefaultValue = 3;
			
		}	
		

		/// <summary>
		/// Higher zIndex than column series to draw line above shapes.
		/// </summary>
		public PlotOptionsParetoZIndex ZIndex { get; set; }
		private PlotOptionsParetoZIndex ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Higher zIndex than column series to draw line above shapes.
		/// </summary>
		public PlotOptionsParetoZIndex ZIndex { get; set; }
		private PlotOptionsParetoZIndex ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

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