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
	public partial class Loading  : BaseObject
	{
		public Loading()
		{
			LabelStyle = LabelStyle_DefaultValue = new Hashtable();
			Style = Style_DefaultValue = new Hashtable();
			HideDuration = HideDuration_DefaultValue = 100;
			ShowDuration = ShowDuration_DefaultValue = 100;
			
		}	
		

		/// <summary>
		/// <p>CSS styles for the loading label <code>span</code>.</p>
		/// </summary>
		public Hashtable LabelStyle { get; set; }
		private Hashtable LabelStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the loading screen that covers the plot area.</p>
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The duration in milliseconds of the fade out effect.</p>
		/// </summary>
		public double? HideDuration { get; set; }
		private double? HideDuration_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The duration in milliseconds of the fade in effect.</p>
		/// </summary>
		public double? ShowDuration { get; set; }
		private double? ShowDuration_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LabelStyle.IsDirty()) h.Add("labelStyle",LabelStyle.ToHashtable());
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