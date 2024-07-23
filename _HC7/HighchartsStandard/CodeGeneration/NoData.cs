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
	public partial class NoData  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NoData()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// An object of additional SVG attributes for the no-data label.
		/// </summary>
		public Hashtable Attr { get; set; }
		 

		/// <summary>
		/// The position of the no-data label, relative to the plot area.
		/// </summary>
		public NoDataPosition Position { get; set; }
		 

		/// <summary>
		/// CSS styles for the no-data label.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// Whether to insert the label as HTML, or as pseudo-HTML rendered withSVG.
		/// </summary>
		public bool? UseHTML { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Attr != null) h.Add("attr",Attr);
			if (Position != null) h.Add("position",Position.ToHashtable(highcharts));
			if (Style != null) h.Add("style",Style);
			if (UseHTML != null) h.Add("useHTML",UseHTML);
			if (CustomFields.Count > 0)
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