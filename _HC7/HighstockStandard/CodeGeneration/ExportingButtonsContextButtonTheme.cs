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
		public ExportingButtonsContextButtonTheme()
		{
			Fill = Fill_DefaultValue = "#ffffff";
			Padding = Padding_DefaultValue = "5";
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
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Default stroke for the buttons.
		/// </summary>
		public string Stroke { get; set; }
		private string Stroke_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Stroke != Stroke_DefaultValue) h.Add("stroke",Stroke);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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