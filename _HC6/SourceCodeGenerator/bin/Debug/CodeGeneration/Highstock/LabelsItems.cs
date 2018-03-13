using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class LabelsItems  : BaseObject
	{
		public LabelsItems()
		{
			Html = Html_DefaultValue = "";
			Style = Style_DefaultValue = new Hashtable();
			
		}	
		

		/// <summary>
		/// Inner HTML or text for the label.
		/// </summary>
		public string Html { get; set; }
		private string Html_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for each label. To position the label, use left and toplike this:<pre>style: {    left: '100px',    top: '100px'}</pre>
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Html != Html_DefaultValue) h.Add("html",Html);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			

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