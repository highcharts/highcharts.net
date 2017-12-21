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
	public partial class LegendTitle  : BaseObject
	{
		public LegendTitle()
		{
			Style = Style_DefaultValue = new Hashtable{{"fontWeight","bold"}};
			Text = Text_DefaultValue = "null";
			
		}	
		

		/// <summary>
		/// Generic CSS styles for the legend title.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// A text or HTML string for the title.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (Text != Text_DefaultValue) h.Add("text",Text);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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