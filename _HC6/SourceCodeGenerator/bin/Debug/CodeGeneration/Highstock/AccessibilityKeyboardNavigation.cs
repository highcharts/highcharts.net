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
	public partial class AccessibilityKeyboardNavigation  : BaseObject
	{
		public AccessibilityKeyboardNavigation()
		{
			Enabled = Enabled_DefaultValue = true;
			FocusBorder = FocusBorder_DefaultValue = new AccessibilityKeyboardNavigationFocusBorder();
			Mode = Mode_DefaultValue = "normal";
			SkipNullPoints = SkipNullPoints_DefaultValue = true;
			
		}	
		

		/// <summary>
		/// Enable keyboard navigation for the chart.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the focus border drawn around elements whilenavigating through them.
		/// </summary>
		public AccessibilityKeyboardNavigationFocusBorder FocusBorder { get; set; }
		private AccessibilityKeyboardNavigationFocusBorder FocusBorder_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the keyboard navigation mode for the chart. Can be "normal"or "serialize". In normal mode, left/right arrow keys movebetween points in a series, while up/down arrow keys move betweenseries. Up/down navigation acts intelligently to figure out whichseries makes sense to move to from any given point.In "serialize" mode, points are instead navigated as a single list. Left/right behaves as in "normal" mode. Up/down arrow keyswill behave like left/right. This is useful for unifying navigation behavior with/without screen readers enabled.
		/// </summary>
		public string Mode { get; set; }
		private string Mode_DefaultValue { get; set; }
		 

		/// <summary>
		/// Skip null points when navigating through points with thekeyboard.
		/// </summary>
		public bool? SkipNullPoints { get; set; }
		private bool? SkipNullPoints_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (FocusBorder.IsDirty()) h.Add("focusBorder",FocusBorder.ToHashtable());
			if (Mode != Mode_DefaultValue) h.Add("mode",Mode);
			if (SkipNullPoints != SkipNullPoints_DefaultValue) h.Add("skipNullPoints",SkipNullPoints);
			

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