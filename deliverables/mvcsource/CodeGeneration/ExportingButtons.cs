using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Highcharts
{
	public partial class ExportingButtons  : BaseObject
	{
		public ExportingButtons()
		{
			ContextButton = ContextButton_DefaultValue = new ExportingButtonsContextButton();
			
		}	
		

		/// <summary>
		/// Options for the export button.
		/// </summary>
		public ExportingButtonsContextButton ContextButton { get; set; }
		private ExportingButtonsContextButton ContextButton_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ContextButton.IsDirty()) h.Add("contextButton",ContextButton.ToHashtable());
			

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