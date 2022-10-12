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
	public partial class NavigationButtonOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationButtonOptions()
		{
			Enabled = Enabled_DefaultValue = true;
			Text = Text_DefaultValue = "null";
			Theme = Theme_DefaultValue = new NavigationButtonOptionsTheme();
			Y = Y_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// Whether to enable buttons.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// A text string to add to the individual button.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigationButtonOptionsTheme Theme { get; set; }
		private NavigationButtonOptionsTheme Theme_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical offset of the button's position relative to its`verticalAlign`.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Theme.IsDirty(ref highstock)) h.Add("theme",Theme.ToHashtable(ref highstock));
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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