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
			Next = Next_DefaultValue = new List<string>();
			Prev = Prev_DefaultValue = new List<string>();
			
		}	
		

		/// <summary>
		/// <p>Array of axes that should move out of the way of resizingbeing done for the current axis. If not set, the next axiswill be used.</p><p>This feature requires the <code>drag-panes.js</code> module.</p>
		/// </summary>
		public List<string> Next { get; set; }
		private List<string> Next_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Array of axes that should move with the current axiswhile resizing.</p><p>This feature requires the <code>drag-panes.js</code> module.</p>
		/// </summary>
		public List<string> Prev { get; set; }
		private List<string> Prev_DefaultValue { get; set; }
		  

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