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
	public partial class IkhSeriesMarkerStatesNormal  : BaseObject
	{
		Hashtable h = new Hashtable();

		public IkhSeriesMarkerStatesNormal()
		{
		}	
		

		/// <summary>
		/// Animation when returning to normal state after hovering.
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Animation when returning to normal state after hovering.
		/// </summary>
		public bool? AnimationBool { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Animation != null) h.Add("animation",Animation);
			if (AnimationBool != null) h.Add("animation",AnimationBool);
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