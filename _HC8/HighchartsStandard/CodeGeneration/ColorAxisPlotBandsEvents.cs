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
	public partial class ColorAxisPlotBandsEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColorAxisPlotBandsEvents()
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

			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("f0087660-0d0b-4bb4-a480-9473c2b45f43.click", Click); }  
			if (Mousemove != Mousemove_DefaultValue) { h.Add("mousemove",Mousemove); Highcharts.AddFunction("2752a555-649a-46ea-9d1b-e9ee825dd498.mousemove", Mousemove); }  
			if (Mouseout != Mouseout_DefaultValue) { h.Add("mouseout",Mouseout); Highcharts.AddFunction("18f3e0cd-d4b3-420f-972c-fbd6e55d3fa6.mouseout", Mouseout); }  
			if (Mouseover != Mouseover_DefaultValue) { h.Add("mouseover",Mouseover); Highcharts.AddFunction("b8af4274-3b87-4fb1-a76a-084cd3dd3b61.mouseover", Mouseover); }  
			

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