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
	public partial class ZAxisPlotBandsEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ZAxisPlotBandsEvents()
		{
			Click = Click_DefaultValue = "";
			Mousemove = Mousemove_DefaultValue = "";
			Mouseout = Mouseout_DefaultValue = "";
			Mouseover = Mouseover_DefaultValue = "";
			
			CustomFields = new Hashtable();
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
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("9b3737f4-2f20-497d-8ead-69aae062babe.click", Click); }  
			if (Mousemove != Mousemove_DefaultValue) { h.Add("mousemove",Mousemove); Highcharts.AddFunction("c50964fd-dc0b-489e-bb5f-9061ee16cfa1.mousemove", Mousemove); }  
			if (Mouseout != Mouseout_DefaultValue) { h.Add("mouseout",Mouseout); Highcharts.AddFunction("b48d4090-7939-4488-82da-8c9f35166f73.mouseout", Mouseout); }  
			if (Mouseover != Mouseover_DefaultValue) { h.Add("mouseover",Mouseover); Highcharts.AddFunction("df0014dd-e51a-4190-a084-4f752c938c98.mouseover", Mouseover); }  
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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