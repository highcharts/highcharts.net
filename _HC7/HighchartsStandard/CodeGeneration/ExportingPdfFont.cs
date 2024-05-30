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
	public partial class ExportingPdfFont  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ExportingPdfFont()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The TTF font file for bold text.
		/// </summary>
		public string Bold { get; set; }
		private string Bold_DefaultValue { get; set; }
		 

		/// <summary>
		/// The TTF font file for bold and italic text.
		/// </summary>
		public string Bolditalic { get; set; }
		private string Bolditalic_DefaultValue { get; set; }
		 

		/// <summary>
		/// The TTF font file for italic text.
		/// </summary>
		public string Italic { get; set; }
		private string Italic_DefaultValue { get; set; }
		 

		/// <summary>
		/// The TTF font file for normal `font-style`. If font variations like`bold` or `italic` are not defined, the `normal` font will be usedfor those too.
		/// </summary>
		public string Normal { get; set; }
		private string Normal_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Bold != null) h.Add("bold",Bold);
			if (Bolditalic != null) h.Add("bolditalic",Bolditalic);
			if (Italic != null) h.Add("italic",Italic);
			if (Normal != null) h.Add("normal",Normal);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}