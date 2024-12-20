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
		}	
		

		/// <summary>
		/// Whether to show the credits text.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// The URL for the credits label.
		/// </summary>
		public string Href { get; set; }
		 

		/// <summary>
		/// Position configuration for the credits label.
		/// </summary>
		public CreditsPosition Position { get; set; }
		 

		/// <summary>
		/// CSS styles for the credits label.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// The text for the credits label.
		/// </summary>
		public string Text { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Href != null) h.Add("href",Href);
			if (Position != null) h.Add("position",Position.ToHashtable(highstock));
			if (Style != null) h.Add("style",Style);
			if (Text != null) h.Add("text",Text);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}