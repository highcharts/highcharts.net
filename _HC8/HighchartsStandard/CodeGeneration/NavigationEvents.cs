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
	public partial class NavigationEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationEvents()
		{
			ClosePopup = ClosePopup_DefaultValue = "";
			DeselectButton = DeselectButton_DefaultValue = "";
			SelectButton = SelectButton_DefaultValue = "";
			ShowPopup = ShowPopup_DefaultValue = "";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// A `closePopup` event. Fired when Popup should be hidden, for examplewhen clicking on an annotation again.
		/// </summary>
		public string ClosePopup { get; set; }
		private string ClosePopup_DefaultValue { get; set; }
		 

		/// <summary>
		/// Event fired when button state should change, for example afteradding an annotation.
		/// </summary>
		public string DeselectButton { get; set; }
		private string DeselectButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// Event fired on a button click.
		/// </summary>
		public string SelectButton { get; set; }
		private string SelectButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `showPopup` event. Fired when selecting for example an annotation.
		/// </summary>
		public string ShowPopup { get; set; }
		private string ShowPopup_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (ClosePopup != ClosePopup_DefaultValue) { h.Add("closePopup",ClosePopup); Highcharts.AddFunction("b9ffb2ae-d5ca-4b5e-8f30-75b10fbcfb21.closePopup", ClosePopup); }  
			if (DeselectButton != DeselectButton_DefaultValue) { h.Add("deselectButton",DeselectButton); Highcharts.AddFunction("766a0403-37c6-454c-a6cc-e3b3af724433.deselectButton", DeselectButton); }  
			if (SelectButton != SelectButton_DefaultValue) { h.Add("selectButton",SelectButton); Highcharts.AddFunction("4b1732dd-cf90-42ee-8cd1-90fd70dd21cf.selectButton", SelectButton); }  
			if (ShowPopup != ShowPopup_DefaultValue) { h.Add("showPopup",ShowPopup); Highcharts.AddFunction("b2bed0d7-3ee1-49fd-89ec-d21b83cc3e82.showPopup", ShowPopup); }  
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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