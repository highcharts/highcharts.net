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
	public partial class XAxisPlotLinesEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public XAxisPlotLinesEvents()
		{
			Click = Click_DefaultValue = "";
			Mousemove = Mousemove_DefaultValue = "";
			Mouseout = Mouseout_DefaultValue = "";
			Mouseover = Mouseover_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Click event on a plot band.
		/// </summary>
		public string Click { get; set; }
		private string Click_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mouse move event on a plot band.
		/// </summary>
		public string Mousemove { get; set; }
		private string Mousemove_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mouse out event on the corner of a plot band.
		/// </summary>
		public string Mouseout { get; set; }
		private string Mouseout_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mouse over event on a plot band.
		/// </summary>
		public string Mouseover { get; set; }
		private string Mouseover_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("5fd48e0b-dfb8-4783-8b70-f17f10c05068.click", Click); }  
			if (Mousemove != Mousemove_DefaultValue) { h.Add("mousemove",Mousemove); Highcharts.AddFunction("14c6f515-abe9-424b-b5a3-5d9e0660557a.mousemove", Mousemove); }  
			if (Mouseout != Mouseout_DefaultValue) { h.Add("mouseout",Mouseout); Highcharts.AddFunction("2af26be5-aae1-4e24-8451-348cbe76e524.mouseout", Mouseout); }  
			if (Mouseover != Mouseover_DefaultValue) { h.Add("mouseover",Mouseover); Highcharts.AddFunction("02ba14df-2d78-4309-bf01-7254cfa61aca.mouseover", Mouseover); }  
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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