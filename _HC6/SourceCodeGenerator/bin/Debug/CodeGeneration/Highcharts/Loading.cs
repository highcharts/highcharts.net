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
	public partial class Loading  : BaseObject
	{
		public Loading()
		{
			LabelStyle = LabelStyle_DefaultValue = new Hashtable();
			Style = Style_DefaultValue = new Hashtable{{ "position", "absolute"},{ "backgroundColor", "#ffffff"},{ "opacity", 0.5},{ "textAlign", "center" }};
			HideDuration = HideDuration_DefaultValue = 100;
			ShowDuration = ShowDuration_DefaultValue = 100;
			
		}	
		

		/// <summary>
		/// CSS styles for the loading label `span`.
		/// </summary>
		public Hashtable LabelStyle { get; set; }
		private Hashtable LabelStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the loading screen that covers the plot area.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The duration in milliseconds of the fade out effect.
		/// </summary>
		public double? HideDuration { get; set; }
		private double? HideDuration_DefaultValue { get; set; }
		 

		/// <summary>
		/// The duration in milliseconds of the fade in effect.
		/// </summary>
		public double? ShowDuration { get; set; }
		private double? ShowDuration_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LabelStyle != LabelStyle_DefaultValue) h.Add("labelStyle",LabelStyle);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (HideDuration != HideDuration_DefaultValue) h.Add("hideDuration",HideDuration);
			if (ShowDuration != ShowDuration_DefaultValue) h.Add("showDuration",ShowDuration);
			

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