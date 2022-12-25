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
	public partial class ExportingButtonsContextButtonTheme  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ExportingButtonsContextButtonTheme()
		{
			Fill = Fill_DefaultValue = "#ffffff";
			Padding = Padding_DefaultValue = 5;
			Stroke = Stroke_DefaultValue = "none";
			
		}	
		

		/// <summary>
		/// The default fill exists only to capture hover events.
		/// </summary>
		public string Fill { get; set; }
		private string Fill_DefaultValue { get; set; }
		 

		/// <summary>
		/// Padding for the button.
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Default stroke for the buttons.
		/// </summary>
		public string Stroke { get; set; }
		private string Stroke_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Stroke != Stroke_DefaultValue) h.Add("stroke",Stroke);
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}