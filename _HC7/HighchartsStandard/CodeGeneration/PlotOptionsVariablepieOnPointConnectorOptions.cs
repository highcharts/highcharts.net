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
	public partial class PlotOptionsVariablepieOnPointConnectorOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVariablepieOnPointConnectorOptions()
		{
		}	
		

		/// <summary>
		/// A name for the dash style to use for the connector.
		/// </summary>
		public Hashtable Dashstyle { get; set; }
		 

		/// <summary>
		/// Color of the connector line. By default it's the series' color.
		/// </summary>
		public string Stroke { get; set; }
		 

		/// <summary>
		/// Pixel width of the connector line.
		/// </summary>
		public double? Width { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Dashstyle != null) h.Add("dashstyle",Dashstyle);
			if (Stroke != null) h.Add("stroke",Stroke);
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