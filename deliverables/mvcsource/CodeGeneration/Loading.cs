using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Highcharts
{
	public partial class Loading  : BaseObject
	{
		public Loading()
		{
			HideDuration = HideDuration_DefaultValue = 100;
			LabelStyle = LabelStyle_DefaultValue = new NameValueCollection{{ "fontWeight", "bold"},{ "position", "relative"},{ "top", "45%" }};
			ShowDuration = ShowDuration_DefaultValue = 100;
			Style = Style_DefaultValue = new NameValueCollection();
			
		}	
		

		/// <summary>
		/// The duration in milliseconds of the fade out effect.
		/// </summary>
		public double? HideDuration { get; set; }
		private double? HideDuration_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the loading label <code>span</code>.
		/// </summary>
		public NameValueCollection LabelStyle { get; set; }
		private NameValueCollection LabelStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The duration in milliseconds of the fade in effect.
		/// </summary>
		public double? ShowDuration { get; set; }
		private double? ShowDuration_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the loading screen that covers the plot area. Defaults to:<pre>style: {position: 'absolute',backgroundColor: 'white',opacity: 0.5,textAlign: 'center'}</pre>
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (HideDuration != HideDuration_DefaultValue) h.Add("hideDuration",HideDuration);
			if (LabelStyle != LabelStyle_DefaultValue) h.Add("labelStyle",LabelStyle);
			if (ShowDuration != ShowDuration_DefaultValue) h.Add("showDuration",ShowDuration);
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