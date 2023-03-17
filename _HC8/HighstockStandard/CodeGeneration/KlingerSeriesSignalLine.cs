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
	public partial class KlingerSeriesSignalLine  : BaseObject
	{
		Hashtable h = new Hashtable();

		public KlingerSeriesSignalLine()
		{
			Styles = Styles_DefaultValue = new KlingerSeriesSignalLineStyles();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Styles for a signal line.
		/// </summary>
		public KlingerSeriesSignalLineStyles Styles { get; set; }
		private KlingerSeriesSignalLineStyles Styles_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Styles.IsDirty(highstock)) h.Add("styles",Styles.ToHashtable(highstock));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}