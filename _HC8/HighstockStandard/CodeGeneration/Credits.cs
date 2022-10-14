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
			Position = Position_DefaultValue = new CreditsPosition();
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
		public CreditsPosition Position { get; set; }
		private CreditsPosition Position_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Href != Href_DefaultValue) h.Add("href",Href);
			if (Position.IsDirty(highstock)) h.Add("position",Position.ToHashtable(highstock));
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			

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