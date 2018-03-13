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
	public partial class NavigatorYAxisResizeControlledAxis  : BaseObject
	{
		public NavigatorYAxisResizeControlledAxis()
		{
			Next = Next_DefaultValue = [];
			Prev = Prev_DefaultValue = [];
			
		}	
		

		/// <summary>
		/// Array of axes that should move out of the way of resizingbeing done for the current axis. If not set, the next axiswill be used.This feature requires the `drag-panes.js` module.
		/// </summary>
		public NavigatorYAxisResizeControlledAxisNext Next { get; set; }
		private NavigatorYAxisResizeControlledAxisNext Next_DefaultValue { get; set; }
		 

		/// <summary>
		/// Array of axes that should move with the current axiswhile resizing.This feature requires the `drag-panes.js` module.
		/// </summary>
		public NavigatorYAxisResizeControlledAxisPrev Prev { get; set; }
		private NavigatorYAxisResizeControlledAxisPrev Prev_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Next != Next_DefaultValue) h.Add("next",Next);
			if (Prev != Prev_DefaultValue) h.Add("prev",Prev);
			

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