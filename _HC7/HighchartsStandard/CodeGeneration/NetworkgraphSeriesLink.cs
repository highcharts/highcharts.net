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
	public partial class NetworkgraphSeriesLink  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NetworkgraphSeriesLink()
		{
		}	
		

		/// <summary>
		/// Color of the link between two nodes.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// A name for the dash style to use for links.
		/// </summary>
		public NetworkgraphSeriesLinkDashStyle DashStyle { get; set; }
		 

		/// <summary>
		/// Opacity of the link between two nodes.
		/// </summary>
		public double? Opacity { get; set; }
		 

		/// <summary>
		/// Width (px) of the link between two nodes.
		/// </summary>
		public double? Width { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Color != null) h.Add("color",Color);
			if (DashStyle != NetworkgraphSeriesLinkDashStyle.Null) h.Add("dashStyle", highcharts.FirstCharacterToLower(DashStyle.ToString()));
			if (Opacity != null) h.Add("opacity",Opacity);
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