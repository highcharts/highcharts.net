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
	public partial class ColorAxisPlotLinesEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColorAxisPlotLinesEvents()
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

			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("18d601cd-5ae7-4976-be09-f4a66b88a574.click", Click); }  
			if (Mousemove != Mousemove_DefaultValue) { h.Add("mousemove",Mousemove); Highcharts.AddFunction("67fe6ecb-6346-474d-97bd-1c1aa5fa190b.mousemove", Mousemove); }  
			if (Mouseout != Mouseout_DefaultValue) { h.Add("mouseout",Mouseout); Highcharts.AddFunction("9e6e9a57-0939-4b69-91ac-b59492f6dd81.mouseout", Mouseout); }  
			if (Mouseover != Mouseover_DefaultValue) { h.Add("mouseover",Mouseover); Highcharts.AddFunction("6ebf36f8-c7eb-4f7c-993b-ecce8e9dabc6.mouseover", Mouseover); }  
			

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