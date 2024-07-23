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
	public partial class YAxisPlotBandsEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public YAxisPlotBandsEvents()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Click event on a plot band.
		/// </summary>
		public string Click { get; set; }
		 

		/// <summary>
		/// Mouse move event on a plot band.
		/// </summary>
		public string Mousemove { get; set; }
		 

		/// <summary>
		/// Mouse out event on the corner of a plot band.
		/// </summary>
		public string Mouseout { get; set; }
		 

		/// <summary>
		/// Mouse over event on a plot band.
		/// </summary>
		public string Mouseover { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Click != null) { h.Add("click",Click); highcharts.AddFunction("click", Click); }  
			if (Mousemove != null) { h.Add("mousemove",Mousemove); highcharts.AddFunction("mousemove", Mousemove); }  
			if (Mouseout != null) { h.Add("mouseout",Mouseout); highcharts.AddFunction("mouseout", Mouseout); }  
			if (Mouseover != null) { h.Add("mouseover",Mouseover); highcharts.AddFunction("mouseover", Mouseover); }  
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