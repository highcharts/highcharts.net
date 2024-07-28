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
	public partial class NavigationAnnotationsOptionsControlPointOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationAnnotationsOptionsControlPointOptions()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Events { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Positioner { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Symbol { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Visible { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Width { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Events != null) h.Add("events",Events);
			if (Height != null) h.Add("height",Height);
			if (Positioner != null) { h.Add("positioner",Positioner); highcharts.AddFunction("positioner", Positioner); }  
			if (Style != null) h.Add("style",Style);
			if (Symbol != null) h.Add("symbol",Symbol);
			if (Visible != null) h.Add("visible",Visible);
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