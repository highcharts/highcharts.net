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
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (ClosePopup != ClosePopup_DefaultValue) { h.Add("closePopup",ClosePopup); Highcharts.AddFunction("9334849c-b256-4099-b3a4-b12373eed306.closePopup", ClosePopup); }  
			if (DeselectButton != DeselectButton_DefaultValue) { h.Add("deselectButton",DeselectButton); Highcharts.AddFunction("2874c84c-89e7-44ba-ac8d-e00b83b3fd8d.deselectButton", DeselectButton); }  
			if (SelectButton != SelectButton_DefaultValue) { h.Add("selectButton",SelectButton); Highcharts.AddFunction("13f99166-b51c-460e-92f2-ed962c731918.selectButton", SelectButton); }  
			if (ShowPopup != ShowPopup_DefaultValue) { h.Add("showPopup",ShowPopup); Highcharts.AddFunction("0db6d062-ea82-4a57-bc7f-3f200b9ef8a1.showPopup", ShowPopup); }  
			

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