using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace HighSoft.Web.Mvc
{
	public partial class NoData
	{
		public NoData()
		{
			Attr = Attr_DefaultValue = null;
			Position = Position_DefaultValue = new NameValueCollection{{ "x", "0"},{ "y", "0"},{ "align", "center"},{ "verticalAlign", "middle" }};
			Style = Style_DefaultValue = new NameValueCollection{{ "fontSize", "12px"},{ "fontWeight", "bold"},{ "color", "#60606a" }};
			
		}	
		

		/// <summary>
		/// An object of additional SVG attributes for the no-data label.
		/// </summary>
		public NameValueCollection Attr { get; set; }
		private NameValueCollection Attr_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the no-data label, relative to the plot area. 
		/// </summary>
		public NameValueCollection Position { get; set; }
		private NameValueCollection Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the no-data label. 
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Attr != Attr_DefaultValue) h.Add("attr",Attr);
			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}