using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Maps
{
	public partial class MapLineSeriesStatesNormal  : BaseObject
	{
		public MapLineSeriesStatesNormal()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			
		}	
		

		/// <summary>
		/// Animation options for the fill color when returning from hover state to normal state. The animation adds some latency in order to reduce the effect of flickering when hovering in and out of for example an uneven coastline.
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Animation.IsDirty()) h.Add("animation",Animation.ToJSON());
			

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