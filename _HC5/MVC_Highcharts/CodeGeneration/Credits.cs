using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Credits  : BaseObject
	{
		public Credits()
		{
			Enabled = Enabled_DefaultValue = true;
			Href = Href_DefaultValue = "http://www.highcharts.com";
			Position = Position_DefaultValue = new NameValueCollection();
			Style = Style_DefaultValue = new NameValueCollection{{ "cursor", "pointer"},{ "color", "#999999"},{ "fontSize", "10px" }};
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
		/// Position configuration for the credits label. Supported properties are  <code>align</code>, <code>verticalAlign</code>, <code>x</code> and <code>y</code>. Defaults to <pre>position: {align: 'right',x: -10,verticalAlign: 'bottom',y: -5}</pre>
		/// </summary>
		public NameValueCollection Position { get; set; }
		private NameValueCollection Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the credits label.
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text for the credits label.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Href != Href_DefaultValue) h.Add("href",Href);
			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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