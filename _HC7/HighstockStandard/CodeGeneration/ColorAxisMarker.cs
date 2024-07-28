using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class ColorAxisMarker  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColorAxisMarker()
		{
		}	
		

		/// <summary>
		/// Animation for the marker as it moves between values. Set to`false` to disable animation. Defaults to `{ duration: 50 }`.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Animation for the marker as it moves between values. Set to`false` to disable animation. Defaults to `{ duration: 50 }`.
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// The color of the marker.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Width { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Animation != null) h.Add("animation",Animation);
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (Color != null) h.Add("color",Color);
			if (Width != null) h.Add("width",Width);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}