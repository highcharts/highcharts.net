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
	public partial class LegendNavigation  : BaseObject
	{
		public LegendNavigation()
		{
			ActiveColor = ActiveColor_DefaultValue = "#274b6d";
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			ArrowSize = ArrowSize_DefaultValue = 12;
			InactiveColor = InactiveColor_DefaultValue = "#CCC";
			Style = Style_DefaultValue = new NameValueCollection();
			
		}	
		

		/// <summary>
		/// The color for the active up or down arrow in the legend page navigation.
		/// </summary>
		public string ActiveColor { get; set; }
		private string ActiveColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to animate the pages when navigating up or down. A value of <code>true</code> applies the default navigation given in  the chart.animation option. Additional options can be given as an object containing values for easing and duration.  .
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel size of the up and down arrows in the legend paging navigation.  .
		/// </summary>
		public double? ArrowSize { get; set; }
		private double? ArrowSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the inactive up or down arrow in the legend page navigation.  .
		/// </summary>
		public string InactiveColor { get; set; }
		private string InactiveColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Text styles for the legend page navigation.
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ActiveColor != ActiveColor_DefaultValue) h.Add("activeColor",ActiveColor);
			if (Animation.IsDirty()) h.Add("animation",Animation.ToJSON());
			if (ArrowSize != ArrowSize_DefaultValue) h.Add("arrowSize",ArrowSize);
			if (InactiveColor != InactiveColor_DefaultValue) h.Add("inactiveColor",InactiveColor);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			

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