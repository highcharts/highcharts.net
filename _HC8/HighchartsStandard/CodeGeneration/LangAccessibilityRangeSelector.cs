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
	public partial class LangAccessibilityRangeSelector  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilityRangeSelector()
		{
			ButtonText = ButtonText_DefaultValue = "Select range {buttonText}";
			MaxInputLabel = MaxInputLabel_DefaultValue = "Select end date.";
			MinInputLabel = MinInputLabel_DefaultValue = "Select start date.";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string ButtonText { get; set; }
		private string ButtonText_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MaxInputLabel { get; set; }
		private string MaxInputLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string MinInputLabel { get; set; }
		private string MinInputLabel_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (ButtonText != ButtonText_DefaultValue) h.Add("buttonText",ButtonText);
			if (MaxInputLabel != MaxInputLabel_DefaultValue) h.Add("maxInputLabel",MaxInputLabel);
			if (MinInputLabel != MinInputLabel_DefaultValue) h.Add("minInputLabel",MinInputLabel);
			

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