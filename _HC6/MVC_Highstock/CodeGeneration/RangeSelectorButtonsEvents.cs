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
	public partial class RangeSelectorButtonsEvents  : BaseObject
	{
		public RangeSelectorButtonsEvents()
		{
			Click = Click_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Fires when clicking on the rangeSelector button. One parameter, event, is passed to the function, containing common event information.</p><pre>click: function(e) {  console.log(this);}</pre><p>Return false to stop default button&#39;s click action.</p>
		/// </summary>
		public function Click { get; set; }
		private function Click_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Click != Click_DefaultValue) h.Add("click",Click);
			

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