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

			if (DeselectButton != DeselectButton_DefaultValue) { h.Add("deselectButton",DeselectButton); Highstock.AddFunction("NavigationEventsDeselectButton.deselectButton", DeselectButton); }  
			if (HidePopup != HidePopup_DefaultValue) { h.Add("hidePopup",HidePopup); Highstock.AddFunction("NavigationEventsHidePopup.hidePopup", HidePopup); }  
			if (SelectButton != SelectButton_DefaultValue) { h.Add("selectButton",SelectButton); Highstock.AddFunction("NavigationEventsSelectButton.selectButton", SelectButton); }  
			if (ShowPopup != ShowPopup_DefaultValue) { h.Add("showPopup",ShowPopup); Highstock.AddFunction("NavigationEventsShowPopup.showPopup", ShowPopup); }  
			

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