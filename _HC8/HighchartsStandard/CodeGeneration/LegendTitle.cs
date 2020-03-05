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
	public partial class LegendTitle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LegendTitle()
		{
			Style = Style_DefaultValue = new LegendTitleStyle();
			Text = Text_DefaultValue = "null";
			
		}	
		

		/// <summary>
		/// Generic CSS styles for the legend title.
		/// </summary>
		public LegendTitleStyle Style { get; set; }
		private LegendTitleStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// A text or HTML string for the title.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			

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