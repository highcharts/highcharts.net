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
	public partial class Credits  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Credits()
		{
			Enabled = Enabled_DefaultValue = true;
			Href = Href_DefaultValue = "https://www.highcharts.com?credits";
			Position = Position_DefaultValue = new Hashtable();
			Style = Style_DefaultValue = new Hashtable();
			Text = Text_DefaultValue = "Highcharts.com";
			
		}	
		

		/// <summary>
		/// Whether to show the credits text.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The URL for the credits label.
		/// </summary>
		public string Href { get; set; }
		private string Href_DefaultValue { get; set; }
		 

		/// <summary>
		/// Position configuration for the credits label.
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the credits label.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text for the credits label.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Href != Href_DefaultValue) h.Add("href",Href);
			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}