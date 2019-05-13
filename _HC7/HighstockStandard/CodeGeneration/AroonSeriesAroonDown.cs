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
	public partial class AroonSeriesAroonDown  : BaseObject
	{
		public AroonSeriesAroonDown()
		{
			Styles = Styles_DefaultValue = new AroonSeriesAroonDownStyles();
			
		}	
		

		/// <summary>
		/// Styles for an aroonDown line.
		/// </summary>
		public AroonSeriesAroonDownStyles Styles { get; set; }
		private AroonSeriesAroonDownStyles Styles_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Styles.IsDirty()) h.Add("styles",Styles.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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