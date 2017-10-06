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
	public partial class ColorAxisMarker  : BaseObject
	{
		public ColorAxisMarker()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Color = Color_DefaultValue = "#999999";
			
		}	
		

		/// <summary>
		/// <p>Animation for the marker as it moves between values. Set to <code>false</code>to disable animation. Defaults to <code>{ duration: 50 }</code>.</p>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the marker.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			

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