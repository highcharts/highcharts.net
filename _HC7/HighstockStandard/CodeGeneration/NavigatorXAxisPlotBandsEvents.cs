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
	public partial class NavigatorXAxisPlotBandsEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigatorXAxisPlotBandsEvents()
		{
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
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Click != null) { h.Add("click",Click); highstock.AddFunction("click", Click); }  
			if (Mousemove != null) { h.Add("mousemove",Mousemove); highstock.AddFunction("mousemove", Mousemove); }  
			if (Mouseout != null) { h.Add("mouseout",Mouseout); highstock.AddFunction("mouseout", Mouseout); }  
			if (Mouseover != null) { h.Add("mouseover",Mouseover); highstock.AddFunction("mouseover", Mouseover); }  
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