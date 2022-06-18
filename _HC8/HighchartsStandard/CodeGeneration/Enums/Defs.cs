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
	public partial class Defs  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Defs()
		{
			Arrow = Arrow_DefaultValue = new DefsArrow();
			ReverseArrow = ReverseArrow_DefaultValue = new DefsReverse_arrow();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public DefsArrow Arrow { get; set; }
		private DefsArrow Arrow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public DefsReverse_arrow ReverseArrow { get; set; }
		private DefsReverse_arrow ReverseArrow_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Arrow.IsDirty(ref highcharts)) h.Add("arrow",Arrow.ToHashtable(ref highcharts));
			if (ReverseArrow.IsDirty(ref highcharts)) h.Add("reverseArrow",ReverseArrow.ToHashtable(ref highcharts));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}