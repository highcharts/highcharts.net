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
	public partial class YAxisPlotLinesEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public YAxisPlotLinesEvents()
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

			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("ef09914d-4397-48b3-8341-6fa238c33220.click", Click); }  
			if (Mousemove != Mousemove_DefaultValue) { h.Add("mousemove",Mousemove); Highcharts.AddFunction("ba0d5991-ae48-4702-bd47-4d671217ac02.mousemove", Mousemove); }  
			if (Mouseout != Mouseout_DefaultValue) { h.Add("mouseout",Mouseout); Highcharts.AddFunction("39ee88a7-7e34-4eaa-8274-bb4098b142e8.mouseout", Mouseout); }  
			if (Mouseover != Mouseover_DefaultValue) { h.Add("mouseover",Mouseover); Highcharts.AddFunction("172eec4a-7b4d-4e61-8c67-af26cf5a0728.mouseover", Mouseover); }  
			

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