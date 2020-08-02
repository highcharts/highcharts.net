using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class HeatmapSeriesMarkerStatesSelect  : BaseObject
	{
		Hashtable h = new Hashtable();

		public HeatmapSeriesMarkerStatesSelect()
		{
			HeightPlus = HeightPlus_DefaultValue = new Hashtable();
			WidthPlus = WidthPlus_DefaultValue = new Hashtable();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The number of pixels to increase the height of thehovered point.
		/// </summary>
		public Hashtable HeightPlus { get; set; }
		private Hashtable HeightPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of pixels to increase the width of thehovered point.
		/// </summary>
		public Hashtable WidthPlus { get; set; }
		private Hashtable WidthPlus_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (HeightPlus != HeightPlus_DefaultValue) h.Add("heightPlus",HeightPlus);
			if (WidthPlus != WidthPlus_DefaultValue) h.Add("widthPlus",WidthPlus);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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