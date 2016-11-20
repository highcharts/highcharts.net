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
	public partial class NoData  : BaseObject
	{
		public NoData()
		{
			Attr = Attr_DefaultValue = null;
			Position = Position_DefaultValue = new Hashtable();
			Style = Style_DefaultValue = new Hashtable{{ "fontSize", "12px"},{ "fontWeight", "bold"},{ "color", "#666666" }};
			UseHTML = UseHTML_DefaultValue = false;
			
		}	
		

		/// <summary>
		/// An object of additional SVG attributes for the no-data label.
		/// </summary>
		public Hashtable Attr { get; set; }
		private Hashtable Attr_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the no-data label, relative to the plot area. 
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the no-data label. 
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to insert the label as HTML, or as pseudo-HTML rendered with SVG.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Attr != Attr_DefaultValue) h.Add("attr",Attr);
			if (Position.IsDirty()) h.Add("position",Position.ToHashtable());
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			

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