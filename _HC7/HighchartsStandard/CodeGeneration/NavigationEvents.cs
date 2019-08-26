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
		public NavigationEvents()
		{
			DeselectButton = DeselectButton_DefaultValue = "";
			HidePopup = HidePopup_DefaultValue = "";
			SelectButton = SelectButton_DefaultValue = "";
			ShowPopup = ShowPopup_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Event fired when button state should change, for example afteradding an annotation.
		/// </summary>
		public string DeselectButton { get; set; }
		private string DeselectButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// A `hidePopop` event. Fired when Popup should be hidden, for exampolewhen clicking on an annotation again.
		/// </summary>
		public string HidePopup { get; set; }
		private string HidePopup_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (DeselectButton != DeselectButton_DefaultValue) { h.Add("deselectButton",DeselectButton); Highcharts.AddFunction("49342e55-833f-47d0-9e73-7423a24e7747.deselectButton", DeselectButton); }  
			if (HidePopup != HidePopup_DefaultValue) { h.Add("hidePopup",HidePopup); Highcharts.AddFunction("608d809c-bb0f-48a7-beb4-ad7b92eac601.hidePopup", HidePopup); }  
			if (SelectButton != SelectButton_DefaultValue) { h.Add("selectButton",SelectButton); Highcharts.AddFunction("a3c2421c-e6aa-4d24-91e8-bfc2a723e476.selectButton", SelectButton); }  
			if (ShowPopup != ShowPopup_DefaultValue) { h.Add("showPopup",ShowPopup); Highcharts.AddFunction("83b64266-1464-4048-89cd-d8f256e98201.showPopup", ShowPopup); }  
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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