using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
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
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ClosePopup != ClosePopup_DefaultValue) { h.Add("closePopup",ClosePopup); highstock.AddFunction("closePopup", ClosePopup); }  
			if (DeselectButton != DeselectButton_DefaultValue) { h.Add("deselectButton",DeselectButton); highstock.AddFunction("deselectButton", DeselectButton); }  
			if (SelectButton != SelectButton_DefaultValue) { h.Add("selectButton",SelectButton); highstock.AddFunction("selectButton", SelectButton); }  
			if (ShowPopup != ShowPopup_DefaultValue) { h.Add("showPopup",ShowPopup); highstock.AddFunction("showPopup", ShowPopup); }  
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}